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

        public static NotifyFilters ProcessWatcherFiltersAsPiped(Watcher watcher)
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

        public static List<NotifyFilters> ProcessWatcherFiltersAsList(Watcher watcher)
        {
            List<NotifyFilters> filters = new List<NotifyFilters>();

            if (watcher.WatchFileName)
                filters.Add(NotifyFilters.FileName);

            if (watcher.WatchDirectoryName)
                filters.Add(NotifyFilters.DirectoryName);

            if (watcher.WatchSize)
                filters.Add(NotifyFilters.Size);

            if (watcher.WatchLastWrite)
                filters.Add(NotifyFilters.LastWrite);

            if (watcher.WatchLastAccess)
                filters.Add(NotifyFilters.LastAccess);

            if (watcher.WatchCreationTime)
                filters.Add(NotifyFilters.CreationTime);

            if (watcher.WatchSecurity)
                filters.Add(NotifyFilters.Security);

            return filters;
        }
    }
}
