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
    public partial class MainForm : BaseForm
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

            // Register control events.
            menuItemAddLink.Click += MenuItemAddLink_Click;
            menuItemSeedTestLink.Click += MenuItemSeedTestLink_Click;
            watchedDirs.MouseClick += WatchedDirs_MouseClick;
            contextItemStartWatchingLink.Click += ContextItemStartWatchingLink_Click;
            contextItemForceCopy.Click += ContextItemForceCopy_Click;
            watchedDirs.Resize += WatchedDirs_Resize;

            // Add some padding to the the list view cells with this image workaround.
            ImageList emptyImageList = new ImageList();
            emptyImageList.ImageSize = new Size(1, 16);
            watchedDirs.SmallImageList = emptyImageList;

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(16, 16);

            DirWatchTransferApp.ListViewImageList.ForEach((imageConfig) => imageList.Images.Add(Image.FromFile(Path.Combine(Environment.CurrentDirectory, imageConfig.Path))));

            listHistory.SmallImageList = imageList;
        }

        /// <summary>
        /// Initial form lifecycle event used for querying the existing symbolic links from the SQLite database.
        /// </summary>
        protected override async void CreateHandle()
        {
            DirWatchTransferApp.SymbolicLinks = await this.SymbolicLinkUtil.ListAllAsync();

            ToolStripMenuItem startWatchers = new ToolStripMenuItem("Start watchers");
            startWatchers.Enabled = DirWatchTransferApp.SymbolicLinks.Count != 0;
            watchersToolStripMenuItem.DropDownItems.Add(startWatchers);
            startWatchers.Click += StartWatchers_Click;

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
            string[] data = new string[] { sourcePath, targetPath, "Stopped" };
            ListViewItem item = new ListViewItem(data);
            item.UseItemStyleForSubItems = false;
            ListViewItem.ListViewSubItem statusSubItem = item.SubItems[2];
            statusSubItem.ForeColor = Color.FromArgb(220, 53, 69);
            watchedDirs.Items.Add(item);

            this.AddHistoryItem($"Linked created between {sourcePath} and {targetPath}", DirWatchTransferApp.LinkedFolderImageConfig.ImageIndex);
        }

        public async Task CreateSymbolicLink(string sourcePath, string targetPath)
        {
            // Adds symbolic link to SQLite and application variable.
            await this.SymbolicLinkUtil.AddAsync(new SymbolicLink()
            {
                Source = sourcePath,
                Target = targetPath,
                Monitor = new SymbolicLinkMonitor()
            });

            // UI methods.
            this.AddSymbolicLinkToList(sourcePath, targetPath);
            this.AddHistoryItem($"Linked created between {sourcePath} and {targetPath}", DirWatchTransferApp.LinkedFolderImageConfig.ImageIndex);
        }

        private void AddHistoryItem(string text, int imageIndex)
        {
            ListViewItem item = new ListViewItem(text, imageIndex);
            listHistory.Items.Add(item);
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            base.AutoSizeColumns(watchedDirs);
        }

        private void WatchedDirs_Resize(object sender, EventArgs e)
        {
            base.AutoSizeColumns((ListView)sender);
        }

        private void MenuItemAddLink_Click(object sender, EventArgs e)
        {
            CreateLinkForm createLinkForm = new CreateLinkForm();
            createLinkForm.ShowDialog(this);
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

        private void ContextItemStartWatchingLink_Click(object sender, EventArgs e)
        {
        }

        private void ContextItemForceCopy_Click(object sender, EventArgs e)
        {
            string sourcePath = watchedDirs.FocusedItem.Text;
            CopyDiagnostics copyDiagnostics = this.SymbolicLinkUtil.SyncLinkedDirectory(sourcePath);

            this.AddHistoryItem($"Directory contents copied from {copyDiagnostics.SourcePath} to {copyDiagnostics.TargetPath} ({copyDiagnostics.ElapsedTime} ms)", DirWatchTransferApp.StatusInformationImageConfig.ImageIndex);
        }

        private async void MenuItemSeedTestLink_Click(object sender, EventArgs e)
        {
            await this.CreateSymbolicLink(@"C:\Users\Nick\Documents\Sample", @"C:\Users\Nick\Documents\Target");
        }

        private void StartWatchers_Click(object sender, EventArgs e)
        {
            this.SymbolicLinkUtil.BulkStartWatchers();

            // Remove "Start watchers" menu item for main menu.
            watchersToolStripMenuItem.DropDownItems.RemoveAt(0);

            // Add a "Stop watchers" menu item to the main menu.
            ToolStripMenuItem stopWatchers = new ToolStripMenuItem("Stop watchers");
            stopWatchers.Click += StopWatchers_Click;
            watchersToolStripMenuItem.DropDownItems.Insert(0, stopWatchers);

            this.AddHistoryItem($"Initialized the watcher(s) for ({DirWatchTransferApp.SymbolicLinks.Count}) symbolic links", DirWatchTransferApp.TimeImageConfig.ImageIndex);
        }

        private void StopWatchers_Click(object sender, EventArgs e)
        {
            this.SymbolicLinkUtil.BulkStopWatchers();

            // Remove "Start watchers" menu item for main menu.
            watchersToolStripMenuItem.DropDownItems.RemoveAt(0);

            // Add a "Stop watchers" menu item to the main menu.
            ToolStripMenuItem startWatchers = new ToolStripMenuItem("Start watchers");
            startWatchers.Click += StartWatchers_Click;
            watchersToolStripMenuItem.DropDownItems.Insert(0, startWatchers);

            this.AddHistoryItem($"Stopped the watcher(s) for ({DirWatchTransferApp.SymbolicLinks.Count}) symbolic links", DirWatchTransferApp.StatusOfflineConfig.ImageIndex);
        }

        // this.AddHistoryItem($"Link created copy of {copyDiagnostics.SourcePath} at {copyDiagnostics.TargetPath} ({copyDiagnostics.ElapsedTime} ms)", DirWatchTransferApp.LinkImageConfig.ImageIndex);

        #endregion
    }
}