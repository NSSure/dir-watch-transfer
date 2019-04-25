using DirWatchTransfer.Entity;
using DirWatchTransfer.Utilities;
using System;
using System.IO;
using System.Linq;

namespace DirWatchTransfer.Model
{
    public class Monitor
    {
        public int ID { get; set; }

        public delegate void CopyCompletedDelegate(CopyDiagnostics copyDiagnostics);
        public event CopyCompletedDelegate OnCopyCompleted;

        public Action<CopyDiagnostics> CopyCompletedAction;

        public DateTime LastTimeWatcherFired { get; set; }

        private FileSystemWatcher watcher { get; set; } = new FileSystemWatcher();

        public Monitor()
        {

        }

        public Monitor(Action<CopyDiagnostics> copyCompleted)
        {
            this.CopyCompletedAction = copyCompleted;
        }

        public FileSystemWatcher StartWatcher(string sourcePath)
        {
            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);

             //symbolicLink.Monitor = this;

            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
            }

            this.watcher.Path = sourcePath;
            this.watcher.IncludeSubdirectories = true;
            // this.watcher.NotifyFilter = this.ProcessFilters(symbolicLink);

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

        private NotifyFilters ProcessFilters(Watcher watcher)
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
