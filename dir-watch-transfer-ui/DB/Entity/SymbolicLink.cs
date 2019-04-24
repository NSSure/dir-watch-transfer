using System;

namespace dir_watch_transfer_ui.Model
{
    public class SymbolicLink
    {
        public SymbolicLink()
        {
            this.Monitor = new SymbolicLinkMonitor();
        }

        public SymbolicLink(Action<CopyDiagnostics> copyCompletedCallback)
        {
            this.Monitor = new SymbolicLinkMonitor(copyCompletedCallback);
        }

        public int ID { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public bool Recursive { get; set; }
        public bool WatchFileName { get; set; }
        public bool WatchDirectoryName { get; set; }
        public bool WatchSize { get; set; }
        public bool WatchLastWrite { get; set; }
        public bool WatchLastAccess { get; set; }
        public bool WatchCreationTime { get; set; }
        public bool WatchSecurity { get; set; }
        public SymbolicLinkMonitor Monitor { get; set; }
    }
}
