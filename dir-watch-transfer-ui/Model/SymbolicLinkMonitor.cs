﻿using dir_watch_transfer_ui.Utilities;
using System;
using System.IO;
using System.Linq;
using System.Timers;

namespace dir_watch_transfer_ui.Model
{
    public class SymbolicLinkMonitor
    {
        private FileSystemWatcher watcher { get; set; } = new FileSystemWatcher();

        public FileSystemWatcher StartWatcher(string sourcePath)
        {
            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);

            symbolicLink.Monitor = new SymbolicLinkMonitor();

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
            // this.OnWatcherFired?.Invoke(Path.Combine(e.FullPath, e.Name));
        }

        private void SymbolicLinkWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            CopyDiagnostics copyDiagnostics = new SymbolicLinkUtility().SyncLinkedFile(e.Name, e.FullPath);
            // this.OnWatcherFired?.Invoke(Path.Combine(e.FullPath, e.Name));
        }
    }
}
