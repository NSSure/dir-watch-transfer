using dir_watch_transfer_ui.Forms;
using dir_watch_transfer_ui.Model;
using dir_watch_transfer_ui.Utilities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace dir_watch_transfer_ui
{
    public partial class MainForm : Form
    {
        public SymbolicLinkUtility SymbolicLinkUtil
        {
            get
            {
                return new SymbolicLinkUtility();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            watchedDirs.DoubleBuffer();

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(16,16);
            imageList.Images.Add(Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Images/LinkedFolder.png")));
            imageList.Images.Add(Image.FromFile(Path.Combine(Environment.CurrentDirectory, "Images/StatusInformation.png")));

            listHistory.SmallImageList = imageList;

            //progressCopy.Maximum = 100;
            //progressCopy.Step = 1;
            //progressCopy.Value = 0;

            ToolStripMenuItem startWatchers = new ToolStripMenuItem("Start watchers");
            watchersToolStripMenuItem.DropDownItems.Add(startWatchers);

            // Register control events.
            menuItemAddLink.Click += MenuItemAddLink_Click;
            menuItemSeedTestLink.Click += MenuItemSeedTestLink_Click;
            watchedDirs.MouseClick += WatchedDirs_MouseClick;
            contextItemStartWatchingLink.Click += ContextItemForceCopy_Click;
            startWatchers.Click += StartWatchers_Click;

            //// Source column
            //watchedDirs.Columns[0].Width = -2;

            //// Target column
            //watchedDirs.Columns[1].Width = -2;

            //// Status column
            //watchedDirs.Columns[2].Width = -2;

            // Add some padding to the the list view cells with this image workaround.
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1,16);
            watchedDirs.SmallImageList = imgList;
        }

        private void MenuItemAddLink_Click(object sender, EventArgs e)
        {
            CreateLinkForm createLinkForm = new CreateLinkForm();
            createLinkForm.ShowDialog(this);
        }

        /// <summary>
        /// Initial form lifecycle event used for querying the existing symbolic links from the SQLite database.
        /// </summary>
        protected override async void CreateHandle()
        {
            DirWatchTransferApp.SymbolicLinks = await this.SymbolicLinkUtil.ListAllAsync();

            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                this.AddSymbolicLinkToList(symbolicLink.Source, symbolicLink.Target);
            }

            base.CreateHandle();
        }

        /// <summary>
        /// Create a new list view row for a newly created link between the source and target directories.
        /// </summary>
        /// <param name="sourcePath">Path of the source directory.</param>
        /// <param name="targetPath">Path of the target directory.</param>
        private void AddSymbolicLinkToList(string sourcePath, string targetPath)
        {
            string[] data = new string[] { sourcePath, targetPath, "Stopped", "Force copy" };
            ListViewItem item = new ListViewItem(data);
            item.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item.UseItemStyleForSubItems = false;
            ListViewItem.ListViewSubItem statusSubItem = item.SubItems[2];
            statusSubItem.ForeColor = Color.FromArgb(220, 53, 69);
            watchedDirs.Items.Add(item);
        }

        public async Task CreateSymbolicLink(string sourcePath, string targetPath)
        {
            this.AddSymbolicLinkToList(sourcePath, targetPath);

            SymbolicLink symbolicLink = new SymbolicLink()
            {
                Source = sourcePath,
                Target = targetPath,
                Watcher = this.StartWatcher(sourcePath)
            };

            await this.SymbolicLinkUtil.AddAsync(symbolicLink);
            DirWatchTransferApp.SymbolicLinks.Add(symbolicLink);

            ListViewItem historyItem = new ListViewItem($"Linked created between {sourcePath} and {targetPath}");
            historyItem.ImageIndex = 0;
            listHistory.Items.Add(historyItem);
        }

        private FileSystemWatcher StartWatcher(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path = path;
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.LastWrite;

            watcher.Changed += Watcher_Fired;
            watcher.Created += Watcher_Fired;

            // Begin watching directory
            watcher.EnableRaisingEvents = true;

            return watcher;
        }

        private void StopWatcher(FileSystemWatcher watcher)
        {
            watcher.EnableRaisingEvents = false;

            watcher.Changed -= Watcher_Fired;
            watcher.Created -= Watcher_Fired;

            watcher.Dispose();
        }

        private void WatchedDirs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (watchedDirs.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenu.Show(Cursor.Position);
                }
            }
        }

        private void ContextItemForceCopy_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string sourcePath = watchedDirs.FocusedItem.Text;
            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);
            // DirWatchTransferApp.DirectoryCopy(symbolicLink.Source, symbolicLink.Target, true);

            CopyReporter copyReporter = new CopyReporter();

            copyReporter.OnDirectoryProgress += CopyReporter_OnDirectoryProgress;

            copyReporter.CopyDirectory(symbolicLink.Source, symbolicLink.Target, () =>
            {
                // progressCopy.Value = 0;
            });

            stopwatch.Stop();

            ListViewItem historyItem = new ListViewItem($"Directory contents copied from {symbolicLink.Source} to {symbolicLink.Target} ({stopwatch.ElapsedMilliseconds} ms)");
            historyItem.ImageIndex = 1;
            listHistory.Items.Add(historyItem);
        }

        private void CopyReporter_OnDirectoryProgress(double percentage, ref bool cancel)
        {
            if (percentage != double.PositiveInfinity)
            {
                this.Invoke((MethodInvoker)delegate {
                    // progressCopy.Value = (int)percentage;
                });
            }
        }

        private async void MenuItemSeedTestLink_Click(object sender, EventArgs e)
        {
            await this.CreateSymbolicLink(@"C:\Users\Nick\Documents\Sample", @"C:\Users\Nick\Documents\Target");
        }

        private void StartWatchers_Click(object sender, EventArgs e)
        {
            int index = 0;

            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                this.StartWatcher(symbolicLink.Source);

                ListViewItem item = watchedDirs.Items[index];
                ListViewItem.ListViewSubItem subItem = item.SubItems[2];
                subItem.Text = "Watching";
                subItem.ForeColor = Color.FromArgb(40, 167, 69);

                index++;
            }

            watchersToolStripMenuItem.DropDownItems.RemoveAt(0);

            ToolStripMenuItem stopWatchers = new ToolStripMenuItem("Stop watchers");
            stopWatchers.Click += StopWatchers_Click;
            watchersToolStripMenuItem.DropDownItems.Insert(0, stopWatchers);
        }

        private void StopWatchers_Click(object sender, EventArgs e)
        {
            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                this.StopWatcher(symbolicLink.Watcher);
            }
        }

        private void Watcher_Fired(object sender, FileSystemEventArgs e)
        {
            if (true)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string sourcePath = e.FullPath.Replace(@"\" + e.Name, string.Empty);

                this.Invoke((MethodInvoker)delegate {
                    watchedDirs.Items[0].SubItems[2].Text = "Copying...";
                });

                SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);

                string targetFilePath = Path.Combine(symbolicLink.Target, e.Name);
                string targetDirectoryPath = Path.GetDirectoryName(targetFilePath);

                if (!Directory.Exists(targetDirectoryPath))
                {
                    Directory.CreateDirectory(targetDirectoryPath);
                }

                CopyReporter fileCopier = new CopyReporter();
                fileCopier.Copy(e.FullPath, targetFilePath);

                stopwatch.Stop();

                this.Invoke((MethodInvoker)delegate {
                    watchedDirs.Items[0].SubItems[2].Text = $"Copied ({stopwatch.ElapsedMilliseconds} ms)";
                });

                this.Invoke((MethodInvoker)delegate {
                    listHistory.Items.Add($"Link created copy of {sourcePath} at {targetFilePath} ({stopwatch.ElapsedMilliseconds} ms)");
                });
            }
        }

        class CopyReporter
        {
            public delegate void ProgressChangedDelegate(double Persentage, ref bool Cancel);
            public delegate void CompletedDelegate();

            public CopyReporter()
            {
                OnProgressChanged += delegate { };
                OnComplete += delegate { };
            }

            public void CopyDirectory(string sourcePath, string targetPath, Action completedCallback = null)
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
                    bool cancelFlag = false;

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

                                cancelFlag = false;
                                OnDirectoryProgress(percentage, ref cancelFlag);

                                if (cancelFlag == true)
                                {
                                    // Delete dest file here
                                    break;
                                }
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

            public void Copy(string sourcePath, string targetPath)
            {
                byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
                bool cancelFlag = false;

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

                            cancelFlag = false;
                            OnProgressChanged(percentage, ref cancelFlag);

                            if (cancelFlag == true)
                            {
                                // Delete dest file here
                                break;
                            }
                        }
                    }
                }

                OnComplete();
            }

            public string SourceFilePath { get; set; }
            public string DestFilePath { get; set; }

            public event ProgressChangedDelegate OnProgressChanged;
            public event ProgressChangedDelegate OnDirectoryProgress;
            public event CompletedDelegate OnComplete;
        }

        private void ResizeColumnHeaders()
        {
            for (int i = 0; i < watchedDirs.Columns.Count - 1; i++) watchedDirs.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            watchedDirs.Columns[watchedDirs.Columns.Count - 1].Width = -2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ResizeColumnHeaders();
        }
    }
}
