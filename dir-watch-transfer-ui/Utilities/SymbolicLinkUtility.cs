using dir_watch_transfer_ui.DB;
using dir_watch_transfer_ui.Model;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace dir_watch_transfer_ui.Utilities
{
    public class SymbolicLinkUtility : BaseRepository<SymbolicLink>
    {
        public delegate void WatcherFiredDelegate(string sourcePath);
        public event WatcherFiredDelegate OnWatcherFired;

        public delegate void OnDirectoryCopyProgressDelegate(double percentage);
        public event OnDirectoryCopyProgressDelegate OnDirectoryCopyProgress;

        public override Task AddAsync(SymbolicLink entity)
        {
            // Add the symbolic link to the static varible used for the application.
            DirWatchTransferApp.SymbolicLinks.Add(entity);
            return base.AddAsync(entity);
        }

        public void StartLinkWatcher(SymbolicLink symbolicLink, Action<CopyDiagnostics> copyCompleted)
        {
            symbolicLink.Monitor = new SymbolicLinkMonitor(copyCompleted);
            symbolicLink.Monitor.StartWatcher(symbolicLink.Source);
        }

        public void BulkStartLinkWatchers(Action<CopyDiagnostics> copyCompleted)
        {
            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                symbolicLink.Monitor = new SymbolicLinkMonitor(copyCompleted);
                symbolicLink.Monitor.StartWatcher(symbolicLink.Source);
            }
        }

        public void BulkStopWatchers()
        {
            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                symbolicLink.Monitor.StopWatcher();
            }
        }

        public CopyDiagnostics SyncLinkedFile(string fileName, string sourceFilePath)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string sourceDirectoryPath = sourceFilePath.Replace(@"\" + fileName, string.Empty);

            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourceDirectoryPath);

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

        public CopyDiagnostics SyncLinkedDirectory(string symbolicLinkName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Name == symbolicLinkName);

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
