using dir_watch_transfer_ui.DB;
using dir_watch_transfer_ui.Model;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace dir_watch_transfer_ui.Utilities
{
    public class SymbolicLinkUtility : BaseRepository<SymbolicLink>
    {
        public delegate void WatcherFiredDelegate(string sourcePath);
        public event WatcherFiredDelegate OnWatcherFired;

        public delegate void OnDirectoryCopyProgressDelegate(double percentage);
        public event OnDirectoryCopyProgressDelegate OnDirectoryCopyProgress;

        public override Task AddAsync(SymbolicLink entity)
        {
            // Add the symbolic link to the static varible used for the application.
            DirWatchTransferApp.SymbolicLinks.Add(entity);
            return base.AddAsync(entity);
        }

        public async Task<FileSystemWatcher> StartWatcher(string sourcePath)
        {
            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);

            symbolicLink.Watcher = new FileSystemWatcher();

            symbolicLink.Watcher.Path = sourcePath;
            symbolicLink.Watcher.IncludeSubdirectories = true;
            symbolicLink.Watcher.NotifyFilter = NotifyFilters.LastWrite;

            symbolicLink.Watcher.Changed += Watcher_Changed;
            symbolicLink.Watcher.Created += Watcher_Created;

            // Begin watching directory
            symbolicLink.Watcher.EnableRaisingEvents = true;

            return symbolicLink.Watcher;
        }

        public async Task BulkStartWatchers()
        {
            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                symbolicLink.Watcher = new FileSystemWatcher();

                symbolicLink.Watcher.Path = symbolicLink.Source;
                symbolicLink.Watcher.IncludeSubdirectories = true;
                symbolicLink.Watcher.NotifyFilter = NotifyFilters.LastWrite;

                symbolicLink.Watcher.Changed += Watcher_Changed;
                symbolicLink.Watcher.Created += Watcher_Created;

                // Begin watching directory
                symbolicLink.Watcher.EnableRaisingEvents = true;
            }
        }

        public async Task StopWatcher(SymbolicLink symbolicLink)
        {
            symbolicLink.Watcher.EnableRaisingEvents = false;

            symbolicLink.Watcher.Changed -= Watcher_Changed;
            symbolicLink.Watcher.Created -= Watcher_Changed;

            symbolicLink.Watcher.Dispose();
        }

        public async Task BulkStopWatchers()
        {
            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                await this.StopWatcher(symbolicLink);
            }
        }

        public async Task<CopyDiagnostics> SyncLinkedFile(string fileName, string sourceDirectoryPath)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string sourceFilePath = sourceDirectoryPath.Replace(@"\" + fileName, string.Empty);

            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourceFilePath);

            string targetFilePath = Path.Combine(symbolicLink.Target, fileName);
            string targetDirectoryPath = Path.GetDirectoryName(targetFilePath);

            if (!Directory.Exists(targetDirectoryPath))
            {
                Directory.CreateDirectory(targetDirectoryPath);
            }

            CopyUtility copyUtility = new CopyUtility();
            copyUtility.Copy(sourceFilePath, targetFilePath);

            stopwatch.Stop();

            return new CopyDiagnostics()
            {
                SourcePath = sourceFilePath,
                TargetPath = targetFilePath,
                ElapsedTime = stopwatch.ElapsedMilliseconds
            };
        }

        public async Task<CopyDiagnostics> SyncLinkedDirectory(string sourcePath)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);

            CopyUtility copyUtility = new CopyUtility();
            copyUtility.OnDirectoryProgress += CopyUtility_OnDirectoryProgress;

            copyUtility.CopyDirectory(symbolicLink.Source, symbolicLink.Target);

            stopwatch.Stop();

            return new CopyDiagnostics()
            {
                SourcePath = symbolicLink.Source,
                TargetPath = symbolicLink.Target,
                ElapsedTime = stopwatch.ElapsedMilliseconds
            };
        }

        private void CopyUtility_OnDirectoryProgress(double percentage)
        {
            this.OnDirectoryCopyProgress?.Invoke(percentage);
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            this.OnWatcherFired?.Invoke(Path.Combine(e.FullPath, e.Name));
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            this.OnWatcherFired?.Invoke(Path.Combine(e.FullPath, e.Name));
        }
    }
}
