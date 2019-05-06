using DirWatchTransfer.Core.Entity;
using System;
using System.Collections.Generic;

namespace DirWatchTransfer.Core.Model
{
    public class GroupedWatchers
    {
        public int SymbolicLinkID { get; set; }
        public List<Watcher> Watchers { get; set; }
    }
}
