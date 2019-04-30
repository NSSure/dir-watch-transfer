namespace DirWatchTransfer.Core.Entity
{
    public class SymbolicLink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public int CopyCount { get; set; }
        public int AttributeCount { get; set; }
        public int FileNameCount { get; set; }
        public int DirectoryNameCount { get; set; }
        public int SizeCount { get; set; }
        public int LastWriteCount { get; set; }
        public int LastAccessCount { get; set; }
        public int CreationTimeCount { get; set; }
        public int SecurityCount { get; set; }
    }
}
