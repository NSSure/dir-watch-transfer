using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace DirWatchTransfer.Core
{
    public partial class DirWatcherTransferApp
    {
        public static Dictionary<Tuple<int, int>, FileSystemMonitor> Monitors { get; set; } = new Dictionary<Tuple<int, int>, FileSystemMonitor>();

        public static Dictionary<NotifyFilters, string> SymbolicLinkNotifyFilterCountMap = new Dictionary<NotifyFilters, string>()
        {
            { NotifyFilters.Attributes, nameof(SymbolicLink.AttributeCount) },
            { NotifyFilters.CreationTime, nameof(SymbolicLink.CreationTimeCount) },
            { NotifyFilters.DirectoryName, nameof(SymbolicLink.DirectoryNameCount) },
            { NotifyFilters.FileName, nameof(SymbolicLink.FileNameCount) },
            { NotifyFilters.LastAccess, nameof(SymbolicLink.LastAccessCount) },
            { NotifyFilters.LastWrite, nameof(SymbolicLink.LastWriteCount) },
            { NotifyFilters.Security, nameof(SymbolicLink.SecurityCount) },
            { NotifyFilters.Size, nameof(SymbolicLink.SizeCount) }
        };

        public static Dictionary<NotifyFilters, string> WatcherNotifyFilterCountMap = new Dictionary<NotifyFilters, string>()
        {
            { NotifyFilters.Attributes, nameof(Watcher.AttributeCount) },
            { NotifyFilters.CreationTime, nameof(Watcher.CreationTimeCount) },
            { NotifyFilters.DirectoryName, nameof(Watcher.DirectoryNameCount) },
            { NotifyFilters.FileName, nameof(Watcher.FileNameCount) },
            { NotifyFilters.LastAccess, nameof(Watcher.LastAccessCount) },
            { NotifyFilters.LastWrite, nameof(Watcher.LastWriteCount) },
            { NotifyFilters.Security, nameof(Watcher.SecurityCount) },
            { NotifyFilters.Size, nameof(Watcher.SizeCount) }
        };
    }
}
