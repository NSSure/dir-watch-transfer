using DirWatchTransfer.Core.Entity;
using DirWatchTransfer.Core.Model;
using DirWatchTransfer.Core.Utility;
using DirWatchTransfer.DB;
using System.Threading.Tasks;

namespace DirWatchTransfer.Core.Repository
{
    public class SymbolicLinkRepository : BaseRepository<SymbolicLink>
    {
        public SymbolicLinkRepository()
        {
        }

        public async Task ForceCopy(long watcherID)
        {
            Watcher watcher = await new WatcherRepository().FirstOrDefaultAsync(a => a.ID == watcherID);
            SymbolicLink symbolicLink = await this.FirstOrDefaultAsync(a => a.ID == watcher.SymbolicLinkID);

            CopyUtility copyUtil = new CopyUtility();
            copyUtil.Copy(symbolicLink.Source, symbolicLink.Target);
        }

        public delegate void WatcherFiredDelegate(string sourcePath);
        public event WatcherFiredDelegate OnWatcherFired;

        public delegate void OnDirectoryCopyProgressDelegate(double percentage);
        public event OnDirectoryCopyProgressDelegate OnDirectoryCopyProgress;

        public async override Task AddAsync(SymbolicLink entity)
        {
            // Add the symbolic link to the static varible used for the application.
            // DirWatchTransferApp.SymbolicLinks.Add(entity);
            await base.AddAsync(entity);
        }

        public CopyDiagnostics SyncLinkedFile(string fileName, string sourceFilePath)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //string sourceDirectoryPath = sourceFilePath.Replace(@"\" + fileName, string.Empty);

            //SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourceDirectoryPath);

            //string targetFilePath = Path.Combine(symbolicLink.Target, fileName);
            //string targetDirectoryPath = Path.GetDirectoryName(targetFilePath);

            //if (!Directory.Exists(targetDirectoryPath))
            //{
            //    Directory.CreateDirectory(targetDirectoryPath);
            //}

            //CopyUtility copyUtility = new CopyUtility();
            //copyUtility.Copy(sourceFilePath, targetFilePath);

            //stopwatch.Stop();

            //return new CopyDiagnostics()
            //{
            //    SourcePath = sourceFilePath,
            //    TargetPath = targetFilePath,
            //    ElapsedTime = stopwatch.ElapsedMilliseconds
            //};

            return null;
        }

        public CopyDiagnostics SyncLinkedDirectory(string sourcePath)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);

            //CopyUtility copyUtility = new CopyUtility();
            //copyUtility.CopyDirectory(symbolicLink.Source, symbolicLink.Target);

            //stopwatch.Stop();

            //return new CopyDiagnostics()
            //{
            //    SourcePath = symbolicLink.Source,
            //    TargetPath = symbolicLink.Target,
            //    ElapsedTime = stopwatch.ElapsedMilliseconds
            //};

            return null;
        }
    }
}
