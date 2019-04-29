using DirWatchTransfer.Core.Entity;
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

        public async Task StartWatcher(long watcherID)
        {
            if (DirWatcherTransferApp.Monitors.ContainsKey(watcherID))
            {
                throw new System.Exception("Watcher already has monitor running. Please end the existing monitor before starting a new one.");
            }

            bool isTripped = false;

            Watcher watcher = await this.watcherRepo.FirstOrDefaultAsync(a => a.ID == watcherID);
            SymbolicLink symbolicLink = await this.symbolicLinkRepo.FirstOrDefaultAsync(a => a.ID == watcher.SymbolicLinkID);

            FileSystemMonitor fileSystemMonitor = new FileSystemMonitor();

            fileSystemMonitor.CopyCompletedAction = async (fileSystemEventArgs) =>
            {
                if (!isTripped)
                {
                    isTripped = true;

                    CopyDiagnostics copyDiagnostics = await this.SyncLinkedFile(fileSystemEventArgs.Name, fileSystemEventArgs.FullPath);
                    await this.fileSystemHubContext.Clients.All.SendAsync("onFileCopied");

                    isTripped = false;
                }
            };

            fileSystemMonitor.StartWatcher(symbolicLink.Source, this.ProcessWatcherFilters(watcher));
            DirWatcherTransferApp.Monitors.Add(watcherID, fileSystemMonitor);
        }

        public async Task StopWatcher(long watcherID)
        {
            if (DirWatcherTransferApp.Monitors.ContainsKey(watcherID))
            {
                FileSystemMonitor fileSystemMonitor = DirWatcherTransferApp.Monitors[watcherID];
                fileSystemMonitor.StopWatcher();
                DirWatcherTransferApp.Monitors.Remove(watcherID);
            }
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

        public NotifyFilters ProcessWatcherFilters(Watcher watcher)
        {
            NotifyFilters filters = NotifyFilters.Size;

            if (watcher.WatchFileName)
                filters = filters | NotifyFilters.FileName;

            if (watcher.WatchDirectoryName)
                filters = filters | NotifyFilters.DirectoryName;

            if (watcher.WatchSize)
                filters = filters | NotifyFilters.Size;

            if (watcher.WatchLastWrite)
                filters = filters | NotifyFilters.LastWrite;

            if (watcher.WatchLastAccess)
                filters = filters | NotifyFilters.LastAccess;

            if (watcher.WatchCreationTime)
                filters = filters | NotifyFilters.CreationTime;

            if (watcher.WatchSecurity)
                filters = filters | NotifyFilters.Security;

            return filters;
        }
    }
}
