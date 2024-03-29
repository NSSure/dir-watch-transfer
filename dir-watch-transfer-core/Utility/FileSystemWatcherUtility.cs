﻿using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Interface;
using DirWatchTransfer.Core.Model;
using DirWatchTransfer.Core.Repository;
using DirWatchTransfer.Core.SignalR;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace DirWatchTransfer.Core.Utility
{
    [InjectionConfig(Enum.RequestInjectionState.Scoped)]
    public class FileSystemWatcherUtility : IInjection
    {
        private readonly WatcherRepository watcherRepo;
        private readonly SymbolicLinkRepository symbolicLinkRepo;
        private readonly IHubContext<FileSystemHub> fileSystemHubContext;

        public FileSystemWatcherUtility(WatcherRepository watcherRepo, SymbolicLinkRepository symbolicLinkRepo, IHubContext<FileSystemHub> fileSystemHubContext)
        {
            this.watcherRepo = watcherRepo;
            this.symbolicLinkRepo = symbolicLinkRepo;
            this.fileSystemHubContext = fileSystemHubContext;
        }

        public async Task StartWatcher(int watcherID)
        {
            bool isTripped = false;

            Watcher watcher = await this.watcherRepo.FirstOrDefaultAsync(a => a.ID == watcherID);
            SymbolicLink symbolicLink = await this.symbolicLinkRepo.FirstOrDefaultAsync(a => a.ID == watcher.SymbolicLinkID);

            System.Tuple<int, int> monitorKey = new System.Tuple<int, int>(watcher.SymbolicLinkID, watcher.ID);

            if (DirWatcherTransferApp.Monitors.ContainsKey(monitorKey))
            {
                throw new System.Exception("Watcher already has monitor running. Please end the existing monitor before starting a new one.");
            }

            FileSystemMonitor fileSystemMonitor = new FileSystemMonitor();

            // This actions gets fired when a file changes.
            fileSystemMonitor.CopyCompletedAction = async (notifyFilter, fileSystemEventArgs) =>
            {
                // TODO: Implement a better way to check for visual studio temp files. This will fail if the actual file have a "~" in the name.
                if (!isTripped && fileSystemEventArgs.Name.Contains("~") && !fileSystemEventArgs.Name.EndsWith("~"))
                {
                    isTripped = true;

                    string fileName = fileSystemEventArgs.Name;
                    string filePath = fileSystemEventArgs.FullPath;

                    if (fileSystemEventArgs.Name.Contains("~") && !fileSystemEventArgs.Name.EndsWith("~"))
                    {
                        // Remove the vs caching name format.
                        fileName = fileSystemEventArgs.Name.Remove(fileSystemEventArgs.Name.LastIndexOf("~"));
                        filePath = fileSystemEventArgs.FullPath.Replace(fileSystemEventArgs.Name, fileName);
                    }
                    
                    // Sync the changed file with the target file and update the SignalR clients of the copied file.
                    CopyDiagnostics copyDiagnostics = await this.SyncLinkedFile(fileName, filePath);
                    await this.fileSystemHubContext.Clients.All.SendAsync("onFileCopied", copyDiagnostics);

                    await LogUtility.WriteToLog(notifyFilter, copyDiagnostics);

                    // Update counts.
                    if (notifyFilter != null)
                    {
                        await this.symbolicLinkRepo.IncrementCount(fileSystemEventArgs.FullPath.Replace(@"\" + fileSystemEventArgs.Name, string.Empty), (NotifyFilters)notifyFilter);
                        await this.watcherRepo.IncrementCount(watcher, (NotifyFilters)notifyFilter);
                    }

                    isTripped = false;
                }
            };

            fileSystemMonitor.StartWatcher(symbolicLink.Source, DirWatcherTransferApp.ProcessWatcherFiltersAsList(watcher));
            DirWatcherTransferApp.Monitors.Add(monitorKey, fileSystemMonitor);
        }

        public async Task StopWatcher(long watcherID)
        {
            //if (DirWatcherTransferApp.Monitors.ContainsKey(watcherID))
            //{
            //    FileSystemMonitor fileSystemMonitor = DirWatcherTransferApp.Monitors[watcherID];

            //    fileSystemMonitor.StopWatcher(
            //        NotifyFilters.Attributes | 
            //        NotifyFilters.CreationTime | 
            //        NotifyFilters.DirectoryName | 
            //        NotifyFilters.FileName | 
            //        NotifyFilters.LastAccess | 
            //        NotifyFilters.LastWrite |
            //        NotifyFilters.Security | 
            //        NotifyFilters.Size
            //    );

            //    DirWatcherTransferApp.Monitors.Remove(watcherID);
            //}
        }

        public async Task DeleteWatcher(int watcherID)
        {
            await this.StopWatcher(watcherID);
            await this.watcherRepo.DeleteAsync(watcherID);
        }

        public async Task ForceCopy(long symbolicLinkID)
        {
            SymbolicLink symbolicLink = await this.symbolicLinkRepo.FirstOrDefaultAsync(a => a.ID == symbolicLinkID);

            CopyUtility copyUtil = new CopyUtility();
            copyUtil.Copy(symbolicLink.Source, symbolicLink.Target);
        }

        public async Task<CopyDiagnostics> SyncLinkedFile(string fileName, string sourceFilePath)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string sourceDirectoryPath = sourceFilePath.Replace(@"\" + fileName, string.Empty);

            SymbolicLink symbolicLink = await this.symbolicLinkRepo.FirstOrDefaultAsync(a => a.Source == sourceDirectoryPath);

            string targetFilePath = Path.Combine(symbolicLink.Target, fileName);
            string targetDirectoryPath = Path.GetDirectoryName(targetFilePath);

            if (!Directory.Exists(targetDirectoryPath))
            {
                Directory.CreateDirectory(targetDirectoryPath);
            }

            CopyUtility copyUtility = new CopyUtility();
            copyUtility.Copy(sourceFilePath, targetFilePath);

            stopwatch.Stop();

            return new CopyDiagnostics()
            {
                SourcePath = sourceFilePath,
                TargetPath = targetFilePath,
                ElapsedTime = stopwatch.ElapsedMilliseconds
            };
        }

        public async Task<CopyDiagnostics> SyncLinkedDirectory(string sourcePath)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SymbolicLink symbolicLink = await this.symbolicLinkRepo.FirstOrDefaultAsync(a => a.Source == sourcePath);

            CopyUtility copyUtility = new CopyUtility();
            copyUtility.CopyDirectory(symbolicLink.Source, symbolicLink.Target);

            stopwatch.Stop();

            return new CopyDiagnostics()
            {
                SourcePath = symbolicLink.Source,
                TargetPath = symbolicLink.Target,
                ElapsedTime = stopwatch.ElapsedMilliseconds
            };
        }
    }
}
