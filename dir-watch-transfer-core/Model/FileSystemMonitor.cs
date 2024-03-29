﻿using DirWatchTransfer.Core.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DirWatchTransfer.Core.Model
{
    public class FileSystemMonitor
    {
        public Action<NotifyFilters?, FileSystemEventArgs> CopyCompletedAction;

        private Dictionary<NotifyFilters, FileSystemWatcher> watchers = new Dictionary<NotifyFilters, FileSystemWatcher>();
        private Dictionary<NotifyFilters, string> eventMap = new Dictionary<NotifyFilters, string>()
        {
            { NotifyFilters.Attributes, nameof(FileSystemWatcher_Attributes_Changed) },
            { NotifyFilters.CreationTime, nameof(FileSystemWatcher_CreateTime_Changed) },
            { NotifyFilters.DirectoryName, nameof(SymbolicLinkWatcher_DirectoryName_Changed) },
            { NotifyFilters.FileName, nameof(SymbolicLinkWatcher_FileName_Changed) },
            { NotifyFilters.LastAccess, nameof(SymbolicLinkWatcher_LastAccess_Changed) },
            { NotifyFilters.LastWrite, nameof(SymbolicLinkWatcher_LastWrite_Changed) },
            { NotifyFilters.Security, nameof(SymbolicLinkWatcher_Security_Changed) },
            { NotifyFilters.Size, nameof(SymbolicLinkWatcher_Size_Changed) }
        };

        public FileSystemMonitor()
        {

        }

        public void StartWatcher(string sourcePath, List<NotifyFilters> configuredNotifyFilters)
        {
            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
            }

            foreach (NotifyFilters notifyFilter in configuredNotifyFilters)
            {
                FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

                fileSystemWatcher.Path = sourcePath;
                fileSystemWatcher.IncludeSubdirectories = true;
                fileSystemWatcher.NotifyFilter = notifyFilter;
                fileSystemWatcher.Created += FileSystemWatcher_Created;

                // TODO: This is broken figure out why.
                // fileSystemWatcher.Changed += (FileSystemEventHandler)Delegate.CreateDelegate(typeof(FileSystemEventHandler), this, this.GetType().GetMethod(this.eventMap[notifyFilter]));

                if (notifyFilter == NotifyFilters.FileName)
                    fileSystemWatcher.Changed += SymbolicLinkWatcher_FileName_Changed;

                if (notifyFilter == NotifyFilters.DirectoryName)
                    fileSystemWatcher.Changed += SymbolicLinkWatcher_DirectoryName_Changed;

                if (notifyFilter == NotifyFilters.Size)
                    fileSystemWatcher.Changed += SymbolicLinkWatcher_Size_Changed;

                if (notifyFilter == NotifyFilters.LastWrite)
                    fileSystemWatcher.Changed += SymbolicLinkWatcher_LastWrite_Changed;

                if (notifyFilter == NotifyFilters.LastAccess)
                    fileSystemWatcher.Changed += SymbolicLinkWatcher_LastAccess_Changed;

                if (notifyFilter == NotifyFilters.CreationTime)
                    fileSystemWatcher.Changed += FileSystemWatcher_CreateTime_Changed;

                if (notifyFilter == NotifyFilters.Security)
                    fileSystemWatcher.Changed += SymbolicLinkWatcher_Security_Changed;

                // Begin watching directory
                fileSystemWatcher.EnableRaisingEvents = true;

                this.watchers.Add(notifyFilter, fileSystemWatcher);
            }
        }

        public void StopWatcher(NotifyFilters notifyFilter)
        {
            if (this.watchers.ContainsKey(notifyFilter))
            {
                FileSystemWatcher watcher = this.watchers[notifyFilter];

                watcher.EnableRaisingEvents = false;

                watcher.Changed -= FileSystemWatcher_Created;
                watcher.Changed -= (FileSystemEventHandler)Delegate.CreateDelegate(typeof(FileSystemEventHandler), this, this.GetType().GetMethod(this.eventMap[notifyFilter]));

                watcher.Dispose();
            }
        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(null, e);
        }

        private void FileSystemWatcher_Attributes_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.Attributes, e);
        }

        private void FileSystemWatcher_CreateTime_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.CreationTime, e);
        }

        private void SymbolicLinkWatcher_DirectoryName_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.DirectoryName, e);
        }

        private void SymbolicLinkWatcher_FileName_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.FileName, e);
        }

        private void SymbolicLinkWatcher_LastAccess_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.LastAccess, e);
        }

        private void SymbolicLinkWatcher_LastWrite_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.LastWrite, e);
        }

        private void SymbolicLinkWatcher_Security_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.Security, e);
        }

        public void SymbolicLinkWatcher_Size_Changed(object sender, FileSystemEventArgs e)
        {
            this.CopyCompletedAction?.Invoke(NotifyFilters.Size, e);
        }
    }
}
