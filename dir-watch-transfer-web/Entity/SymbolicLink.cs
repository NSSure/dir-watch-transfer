using DirWatchTransfer.Model;
using System;

namespace DirWatchTransfer.Entity
{
    public class SymbolicLink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
    }
}
