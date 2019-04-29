using DirWatchTransfer.Core.Utility;
using System;
using System.IO;

namespace DirWatchTransfer.Core.Model
{
    public class FileSystemMonitor
    {
        public long WatcherID { get; set; }
        public Action<FileSystemEventArgs> CopyCompletedAction;
        public FileSystemWatcher watcher { get; set; } = new FileSystemWatcher();

        public FileSystemMonitor()
        {

        }

        public void StartWatcher(string sourcePath, NotifyFilters notifyFilters)
        {
            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
            }

            this.watcher.Path = sourcePath;
            this.watcher.IncludeSubdirectories = true;
            this.watcher.NotifyFilter = notifyFilters;

            this.watcher.Changed += SymbolicLinkWatcher_Changed;
            this.watcher.Created += SymbolicLinkWatcher_Created;

            // Begin watching directory
            this.watcher.EnableRaisingEvents = true;
        }

        public void StopWatcher()
        {
            this.watcher.EnableRaisingEvents = false;

            this.watcher.Changed -= SymbolicLinkWatcher_Created;
            this.watcher.Created -= SymbolicLinkWatcher_Changed;

            this.watcher.Dispose();
        }

        private async void SymbolicLinkWatcher_Created(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(e);
        }

        private async void SymbolicLinkWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(e);
        }
    }
}
