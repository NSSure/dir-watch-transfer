using dir_watch_transfer_ui.Utilities;
using System;
using System.IO;
using System.Linq;

namespace dir_watch_transfer_ui.Model
{
    public class SymbolicLinkMonitor
    {
        public delegate void CopyCompletedDelegate(CopyDiagnostics copyDiagnostics);
        public event CopyCompletedDelegate OnCopyCompleted;

        public DateTime LastTimeWatcherFired { get; set; }

        private FileSystemWatcher watcher { get; set; } = new FileSystemWatcher();

        private Action<CopyDiagnostics> copyCompleted;

        public SymbolicLinkMonitor(Action<CopyDiagnostics> copyCompleted)
        {
            this.copyCompleted = copyCompleted;
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
            this.watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size;

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

        private void SymbolicLinkWatcher_Created(object sender, FileSystemEventArgs e)
        {
            CopyDiagnostics copyDiagnostics = new SymbolicLinkUtility().SyncLinkedFile(e.Name, e.FullPath);
            this.copyCompleted?.Invoke(copyDiagnostics);
        }

        private void SymbolicLinkWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            CopyDiagnostics copyDiagnostics = new SymbolicLinkUtility().SyncLinkedFile(e.Name, e.FullPath);
            this.copyCompleted?.Invoke(copyDiagnostics);
        }
    }
}
