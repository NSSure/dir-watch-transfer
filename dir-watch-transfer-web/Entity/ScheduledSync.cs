using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirWatchTransfer.Entity
{
    public class ScheduledSync
    {
        public int ID { get; set; }
        public int SymbolicLinkID { get; set; }
        public bool Enabled { get; set; }
        public DateTime LastSync { get; set; }

        /// <summary>
        /// This is in minutes.
        /// </summary>
        public int Interval { get; set; }
    }
}
