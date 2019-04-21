using System.IO;

namespace dir_watch_transfer_ui.Model
{
    public class SymbolicLink
    {
        public int ID { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public bool Recursive { get; set; }
        public FileSystemWatcher Watcher { get; set; }
    }
}
