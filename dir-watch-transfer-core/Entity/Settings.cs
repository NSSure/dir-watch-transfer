namespace DirWatchTransfer.Core.Entity
{
    public class Settings
    {
        public int ID { get; set; }
        
        /// <summary>
        /// Enables/disable the entirety of the notifications funcitonality. If false all other notification settings are ignored.
        /// </summary>
        public bool EnableNotifications { get; set; } = true;

        /// <summary>
        /// Enable/disable notifications for new symbolic links being added.
        /// </summary>
        public bool EnableNewSymbolicLinkNotifications { get; set; } = false;

        /// <summary>
        /// Enable/disable notifications for new watcher being added.
        /// </summary>
        public bool EnableNewWatcherNotifications { get; set; } = false;

        /// <summary>
        /// Enable/disable notifications for syncs being added.
        /// </summary>
        public bool EnableNewSyncNotifications { get; set; } = false;

        /// <summary>
        /// Enable/disable notifications for when a running watcher copies a file.
        /// </summary>
        public bool EnableWatcherFileSyncsNotifications { get; set; } = false;

        /// <summary>
        /// Enable/disable notifications for when a user force copies a directory.
        /// </summary>
        public bool EnableForcedDirectoryCopiesNotifications { get; set; } = true;

        /// <summary>
        /// Enable/disable the logging of new symbolic links to the log file.
        /// </summary>
        public bool LogNewSymbolicLinks { get; set; } = true;

        /// <summary>
        /// Enable/disable the logging of new watchers to the log file.
        /// </summary>
        public bool LogNewWatchers { get; set; } = true;

        /// <summary>
        /// Enable/disable the logging of new syncs to the log file.
        /// </summary>
        public bool LogNewSyncs { get; set; } = true;

        /// <summary>
        /// Enable/disable the logging of when a running watcher copies a file.
        /// </summary>
        public bool LogWatcherFileSyncs { get; set; } = true;

        /// <summary>
        /// Enable/disable the logging of when a user force copies a directory.
        /// </summary>
        public bool LogForcedDirectoryCopies { get; set; } = true;

        /// <summary>
        /// The file system path to the log file - C:\Users\[User]\AppData\Local\DirWatchTransfer
        /// </summary>
        public string LogFilePath { get; set; } = Constants.LogFilePath;

        /// <summary>
        /// The column structure for the log file output. Default column order is as follows NotifyFilters, SourcePath, TargetPath, ElaspedTime, Timestamp.
        /// </summary>
        public string LogFileFormat { get; set; } = "NotifyFilters,SourcePath,TargetPath,ElaspedTime,Timestamp";
    }
}
