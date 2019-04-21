using dir_watch_transfer_ui.Model;
using dir_watch_transfer_ui.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        public string SourcePlaceholder = "Select source directory";
        public string TargetPlaceholder = "Select target directory";

        protected override async void CreateHandle()
        {
            DirWatchTransferApp.SymbolicLinks = await this.SymbolicLinkUtil.ListAllAsync();

            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                this.AddSymbolicLinkToList(symbolicLink.Source, symbolicLink.Target);
            }

            base.CreateHandle();
        }

        public MainForm()
        {
            InitializeComponent();

            txtSourceDirectory.Text = this.SourcePlaceholder;
            txtSourceDirectory.ForeColor = Color.Gray;

            txtTargetDirectory.Text = this.TargetPlaceholder;
            txtTargetDirectory.ForeColor = Color.Gray;

            txtSourceDirectory.Click += TxtSourceDirectory_Click;
            txtTargetDirectory.Click += TxtTargetDirectory_Click;
            btnCreateWatcher.Click += BtnCreateWatcher_Click;

            menuItemStartWatchers.Click += MenuItemStartWatchers_Click;
            menuItemSeedTestLink.Click += MenuItemSeedTestLink_Click;

            contextItemForceCopy.Click += ContextItemForceCopy_Click;

            // Source column
            watchedDirs.Columns[0].Width = -2;

            // Target column
            watchedDirs.Columns[1].Width = -2;

            // Status column
            watchedDirs.Columns[2].Width = -2;

            // Progress column
            watchedDirs.Columns[3].Width = -2;

            int itemHeight = 35;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, itemHeight);
            watchedDirs.SmallImageList = imgList;

            ListViewExtender extender = new ListViewExtender(watchedDirs);

            ProgressBarColumn progressColumn = new ProgressBarColumn(3);
            progressColumn.FixedWidth = true;

            ListViewButtonColumn buttonColumn = new ListViewButtonColumn(4);
            buttonColumn.Click += OnButtonActionClick;
            buttonColumn.FixedWidth = true;

            extender.AddColumn(progressColumn);
            extender.AddColumn(buttonColumn);

            watchedDirs.MouseClick += WatchedDirs_MouseClick;
        }

        private void ContextItemForceCopy_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ListViewItem listViewItem = watchedDirs.FocusedItem;
            string sourcePath = listViewItem.Text;
            SymbolicLink symbolicLink = DirWatchTransferApp.SymbolicLinks.FirstOrDefault(a => a.Source == sourcePath);
            DirWatchTransferApp.DirectoryCopy(symbolicLink.Source, symbolicLink.Target, true);

            stopwatch.Stop();

            listHistory.Items.Add($"Directory contents copied from {symbolicLink.Source} to {symbolicLink.Target} ({stopwatch.ElapsedMilliseconds} ms)");
        }

        private object ContextMenuRow { get; set; }

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

        private void AddSymbolicLinkToList(string sourcePath, string targetPath)
        {
            string[] data = new string[] { sourcePath, targetPath, "Stopped", "Force copy" };
            ListViewItem item = new ListViewItem(data);
            watchedDirs.Items.Add(item);
        }

        private async void MenuItemSeedTestLink_Click(object sender, EventArgs e)
        {
            await this.CreateSymbolicLink(@"C:\Users\Nick\Documents\Sample", @"C:\Users\Nick\Documents\Target");
        }

        private void MenuItemStartWatchers_Click(object sender, EventArgs e)
        {
            
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
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

            listHistory.Items.Add($"Linked created between {sourcePath} and {targetPath}");
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

        private void Watcher_Fired(object sender, FileSystemEventArgs e)
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

            File.Copy(e.FullPath, targetFilePath, true);

            stopwatch.Stop();

            this.Invoke((MethodInvoker)delegate {
                watchedDirs.Items[0].SubItems[2].Text = $"Copied ({stopwatch.ElapsedMilliseconds} ms)";
            });

            this.Invoke((MethodInvoker)delegate {
                listHistory.Items.Add($"Link created copy of {sourcePath} at {targetFilePath} ({stopwatch.ElapsedMilliseconds} ms)");
            });
        }

        private void TxtSourceDirectory_Click(object sender, EventArgs e)
        {
            if (sourceDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                this.Invoke((MethodInvoker)delegate {
                    txtSourceDirectory.Text = sourceDirectoryDialog.SelectedPath;
                });
            }
        }

        private void TxtTargetDirectory_Click(object sender, EventArgs e)
        {
            if (targetDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                this.Invoke((MethodInvoker)delegate {
                    txtTargetDirectory.Text = targetDirectoryDialog.SelectedPath;
                });
            }
        }

        private async void BtnCreateWatcher_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtSourceDirectory.Text) || txtSourceDirectory.Text == this.SourcePlaceholder) || (string.IsNullOrEmpty(txtTargetDirectory.Text) || txtTargetDirectory.Text == this.TargetPlaceholder))
            {
                MessageBox.Show(this, "A source and target directory must be specified before creating a watcher.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await this.CreateSymbolicLink(txtSourceDirectory.Text, txtTargetDirectory.Text);
        }
    }
}
