using System.IO;

namespace DirWatchTransfer.Core
{
    public class Constants
    {
        public const string ApplicationName = "DirWatchTransfer";

        public const string LogFileName = "dir-watch-transfer-log.txt";

        public static string ApplicationPath
        {
            get
            {
                return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), Constants.ApplicationName);
            }
        }

        public static string LogFilePath
        {
            get
            {
                return Path.Combine(Constants.ApplicationPath, Constants.LogFileName);
            }
        }
    }
}
