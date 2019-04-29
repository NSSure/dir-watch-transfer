﻿using DirWatchTransfer.Core.Model;
using System;

namespace DirWatchTransfer.Core.Entity
{
    public class Watcher
    {
        public int ID { get; set; }
        public int SymbolicLinkID { get; set; }
        public bool Recursive { get; set; }
        public bool WatchFileName { get; set; }
        public bool WatchDirectoryName { get; set; }
        public bool WatchSize { get; set; }
        public bool WatchLastWrite { get; set; }
        public bool WatchLastAccess { get; set; }
        public bool WatchCreationTime { get; set; }
        public bool WatchSecurity { get; set; }
    }
}
