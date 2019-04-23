using System;
using System.IO;

namespace dir_watch_transfer_ui.Utilities
{
    public class CopyUtility
    {

        public delegate void ProgressChangedDelegate(double Persentage);
        public event ProgressChangedDelegate OnProgressChanged;
        public event ProgressChangedDelegate OnDirectoryProgress;

        public event CompletedDelegate OnComplete;
        public delegate void CompletedDelegate();

        public CopyUtility()
        {
            OnProgressChanged += delegate { };
            OnComplete += delegate { };
        }

        public void CopyDirectory(string sourcePath, string targetPath, Action completedCallback = null)
        {
            try
            {
                // Get the subdirectories for the specified directory.
                DirectoryInfo dir = new DirectoryInfo(sourcePath);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + sourcePath);
                }

                // Subdirs
                DirectoryInfo[] dirs = dir.GetDirectories();

                // If the destination directory doesn't exist, create it.
                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }

                // Size of directory and all sub directories.
                long directoryByteLength = 0;
                long processByteLength = 0;

                // Get the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo fileInfo in files)
                {
                    directoryByteLength += fileInfo.Length;
                }

                foreach (FileInfo fileInfo in files)
                {
                    string sourceFilePath = Path.Combine(sourcePath, fileInfo.Name);
                    string targetFilePath = Path.Combine(targetPath, fileInfo.Name);

                    byte[] buffer = new byte[1024 * 1024]; // 1MB buffer

                    using (FileStream sourceFile = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream targetFile = new FileStream(targetFilePath, FileMode.Create, FileAccess.Write))
                        {
                            int currentBlockSize = 0;

                            while ((currentBlockSize = sourceFile.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                processByteLength += currentBlockSize;
                                double percentage = (double)processByteLength * 100.0 / directoryByteLength;
                                targetFile.Write(buffer, 0, currentBlockSize);
                                OnDirectoryProgress(percentage);
                            }
                        }
                    }
                }

                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(targetPath, subdir.Name);
                    this.CopyDirectory(subdir.FullName, temppath);
                }

                if (completedCallback != null)
                {
                    completedCallback.Invoke();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Copy(string sourcePath, string targetPath)
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer

            using (FileStream sourceFile = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            {
                long fileLength = sourceFile.Length;
                using (FileStream targetFile = new FileStream(targetPath, FileMode.Create, FileAccess.Write))
                {
                    long totalBytes = 0;
                    int currentBlockSize = 0;

                    while ((currentBlockSize = sourceFile.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytes += currentBlockSize;
                        double percentage = (double)totalBytes * 100.0 / fileLength;
                        targetFile.Write(buffer, 0, currentBlockSize);
                        OnProgressChanged(percentage);
                    }
                }
            }

            OnComplete();
        }
    }
}
