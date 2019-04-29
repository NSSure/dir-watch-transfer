using DirWatchTransfer.Core.Model;
using System.Collections.Generic;

namespace DirWatchTransfer.Core
{
    public partial class DirWatcherTransferApp
    {
        public static Dictionary<long, FileSystemMonitor> Monitors { get; set; } = new Dictionary<long, FileSystemMonitor>();
    }
}
