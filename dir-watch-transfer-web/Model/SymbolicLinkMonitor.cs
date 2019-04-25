using dir_watch_transfer_web.Entity;
using dir_watch_transfer_web.Utilities;
using DirWatchTransfer;
using System;
using System.IO;
using System.Linq;

namespace dir_watch_transfer_web.Model
{
    public class SymbolicLinkMonitor
    {
        public delegate void CopyCompletedDelegate(CopyDiagnostics copyDiagnostics);
        public event CopyCompletedDelegate OnCopyCompleted;

        public Action<CopyDiagnostics> CopyCompletedAction;

        public DateTime LastTimeWatcherFired { get; set; }

        private FileSystemWatcher watcher { get; set; } = new FileSystemWatcher();

        public SymbolicLinkMonitor()
        {

        }

        public SymbolicLinkMonitor(Action<CopyDiagnostics> copyCompleted)
        {
            this.CopyCompletedAction = copyCompleted;
        }

        public FileSystemWatcher StartWatcher(string sourcePath)
        {
            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);

            symbolicLink.Monitor = this;

            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
            }

            this.watcher.Path = sourcePath;
            this.watcher.IncludeSubdirectories = true;
            this.watcher.NotifyFilter = this.ProcessFilters(symbolicLink);

            this.watcher.Changed += SymbolicLinkWatcher_Changed;
            this.watcher.Created += SymbolicLinkWatcher_Created;

            // Begin watching directory
            this.watcher.EnableRaisingEvents = true;

            return this.watcher;
        }

        public void StopWatcher()
        {
            this.watcher.EnableRaisingEvents = false;

            this.watcher.Changed -= SymbolicLinkWatcher_Created;
            this.watcher.Created -= SymbolicLinkWatcher_Changed;

            this.watcher.Dispose();
        }

        private NotifyFilters ProcessFilters(SymbolicLink symbolicLink)
        {
            NotifyFilters filters = NotifyFilters.Size;

            if (symbolicLink.WatchFileName)
                filters = filters | NotifyFilters.FileName;

            if (symbolicLink.WatchDirectoryName)
                filters = filters | NotifyFilters.DirectoryName;

            if (symbolicLink.WatchSize)
                filters = filters | NotifyFilters.Size;

            if (symbolicLink.WatchLastWrite)
                filters = filters | NotifyFilters.LastWrite;

            if (symbolicLink.WatchLastAccess)
                filters = filters | NotifyFilters.LastAccess;

            if (symbolicLink.WatchCreationTime)
                filters = filters | NotifyFilters.CreationTime;

            if (symbolicLink.WatchSecurity)
                filters = filters | NotifyFilters.Security;

            return filters;
        }

        private void SymbolicLinkWatcher_Created(object sender, FileSystemEventArgs e)
        {
            CopyDiagnostics copyDiagnostics = new SymbolicLinkUtility().SyncLinkedFile(e.Name, e.FullPath);
            this.CopyCompletedAction?.Invoke(copyDiagnostics);
        }

        private void SymbolicLinkWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            CopyDiagnostics copyDiagnostics = new SymbolicLinkUtility().SyncLinkedFile(e.Name, e.FullPath);
            this.CopyCompletedAction?.Invoke(copyDiagnostics);
        }
    }
}
