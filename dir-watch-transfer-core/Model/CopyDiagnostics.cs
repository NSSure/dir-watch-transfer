namespace DirWatchTransfer.Core.Model
{
    public class CopyDiagnostics
    {
        public string SourcePath { get; set; }
        public string TargetPath { get; set; }
        public long ElapsedTime { get; set; }
    }
}
