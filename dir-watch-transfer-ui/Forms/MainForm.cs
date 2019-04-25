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

        public Color ColorSuccess
        {
            get
            {
                return Color.FromArgb(101, 180, 100);
            }
        }

        public Color ColorDanger
        {
            get
            {
                return Color.FromArgb(220, 53, 69);
            }
        }

        public MainForm()   
        {
            InitializeComponent();

            this.Width = 800;
            this.Height = 600;

            this.listSymbolicLinks.DoubleBuffer();
            this.listWatchers.DoubleBuffer();
            this.listSyncs.DoubleBuffer();

            // Register control events.
            menuItemAddLink.Click += MenuItemAddLink_Click;
            listSymbolicLinks.MouseClick += listSymbolicLinks_MouseClick;
            contextItemStartWatchingLink.Click += ContextItemStartWatchingLink_Click;
            contextItemForceCopy.Click += ContextItemForceCopy_Click;
            listSymbolicLinks.Resize += listSymbolicLinks_Resize;
            startWatchers.Click += StartWatchers_Click;
            stopWatchers.Click += StopWatchers_Click;

            // Add some padding to the the list view cells with this image workaround.
            ImageList emptyImageList = new ImageList();
            emptyImageList.ImageSize = new Size(1, 16);
            listSymbolicLinks.SmallImageList = emptyImageList;

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

            foreach (SymbolicLink symbolicLink in DirWatchTransferApp.SymbolicLinks)
            {
                this.AddSymbolicLinkToList(symbolicLink.Name, symbolicLink.Source, symbolicLink.Target, ignoreHistoryLog: true);
            }

            base.CreateHandle();
        }

        /// <summary>
        /// Create a new list view row for a newly created link between the source and target directories.
        /// </summary>
        /// <param name="sourcePath">Path of the source directory.</param>
        /// <param name="targetPath">Path of the target directory.</param>
        private void AddSymbolicLinkToList(string name, string sourcePath, string targetPath, bool ignoreHistoryLog = false)
        {
            string[] data = new string[] { name, sourcePath, targetPath };
            ListViewItem item = new ListViewItem(data);
            item.UseItemStyleForSubItems = false;
            // ListViewItem.ListViewSubItem statusSubItem = item.SubItems[2];
            // statusSubItem.ForeColor = this.ColorDanger;
            listSymbolicLinks.Items.Add(item);

            if (!ignoreHistoryLog)
            {
                this.AddHistoryItem($"Linked created between {sourcePath} and {targetPath}", DirWatchTransferApp.LinkedFolderImageConfig.ImageIndex, ignore: ignoreHistoryLog);
            }
        }

        public async Task CreateSymbolicLink(SymbolicLink symbolicLink)
        {
            symbolicLink.Monitor.CopyCompletedAction = this.OnCopyCompleted;

            // Adds symbolic link to SQLite and application variable.
            await this.SymbolicLinkUtil.AddAsync(symbolicLink);

            // If the watchers drop down item "Start watchers" is disabled make sure to enable it.
            if (watchersToolStripMenuItem.DropDownItems[0].Enabled == false && DirWatchTransferApp.SymbolicLinks.Count != 0)
            {
                watchersToolStripMenuItem.DropDownItems[0].Enabled = true;
            }

            // UI methods.
            this.AddSymbolicLinkToList(symbolicLink.Name, symbolicLink.Source, symbolicLink.Target);
        }

        private void AddHistoryItem(string text, int imageIndex, bool ignore = false)
        {
            if (!ignore)
            {
                this.Invoke((MethodInvoker)delegate {
                    ListViewItem item = new ListViewItem(text, imageIndex);
                    listHistory.Items.Add(item);
                });
            }
        }

        private void AutoSizeColumns(ListView listView)
        {
            int width = (listView.Width / listView.Columns.Count);

            foreach (int columnIndex in Enumerable.Range(0, listView.Columns.Count))
            {
                if (columnIndex == (listView.Columns.Count - 1))
                {
                    listView.Columns[columnIndex].Width = -2;
                }
                else
                {
                    listView.Columns[columnIndex].Width = width;
                }
            }
        }

        #region Events

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await this.CreateSymbolicLink(new SymbolicLink()
            {
                Name = "Sample symbolic link",
                Source = @"C:\DirTestSource",
                Target = @"C:\DirTestTarget",
                WatchSecurity = true,
                Monitor = new SymbolicLinkMonitor()
            });

            this.AutoSizeColumns(this.listSymbolicLinks);
            this.AutoSizeColumns(this.listWatchers);
            this.AutoSizeColumns(this.listSyncs);
        }

        private void listSymbolicLinks_Resize(object sender, EventArgs e)
        {
            this.AutoSizeColumns((ListView)sender);
        }

        private void MenuItemAddLink_Click(object sender, EventArgs e)
        {
            CreateSymbolicLinkForm createLinkForm = new CreateSymbolicLinkForm();
            createLinkForm.ShowDialog(this);
        }

        private void listSymbolicLinks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listSymbolicLinks.FocusedItem.Bounds.Contains(e.Location))
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
            string sourcePath = listSymbolicLinks.FocusedItem.Text;
            CopyDiagnostics copyDiagnostics = this.SymbolicLinkUtil.SyncLinkedDirectory(sourcePath);

            this.AddHistoryItem($"Directory contents copied from {copyDiagnostics.SourcePath} to {copyDiagnostics.TargetPath} ({copyDiagnostics.ElapsedTime} ms)", DirWatchTransferApp.StatusInformationImageConfig.ImageIndex);
        }

        private void StartWatchers_Click(object sender, EventArgs e)
        {
            this.SymbolicLinkUtil.BulkStartWatchers(this.OnCopyCompleted);

            // Remove "Start watchers" menu item for main menu.
            watchersToolStripMenuItem.DropDownItems.RemoveAt(0);

            // Add a "Stop watchers" menu item to the main menu.
            startWatchers.Enabled = false;
            stopWatchers.Enabled = true;

            foreach (ListViewItem item in listSymbolicLinks.Items)
            {
                item.SubItems[2].ForeColor = this.ColorSuccess;
                item.SubItems[2].Text = "Watching...";
            }

            this.AddHistoryItem($"Initialized the watcher(s) for ({DirWatchTransferApp.SymbolicLinks.Count}) symbolic links", DirWatchTransferApp.TimeImageConfig.ImageIndex);
        }

        private void StopWatchers_Click(object sender, EventArgs e)
        {
            this.SymbolicLinkUtil.BulkStopWatchers();

            // Remove "Start watchers" menu item for main menu.
            watchersToolStripMenuItem.DropDownItems.RemoveAt(0);

            // Add a "Stop watchers" menu item to the main menu.
            startWatchers.Enabled = true;
            stopWatchers.Enabled = false;

            foreach (ListViewItem item in listSymbolicLinks.Items)
            {
                item.SubItems[2].ForeColor = this.ColorDanger;
                item.SubItems[2].Text = "Stopped";
            }

            this.AddHistoryItem($"Stopped the watcher(s) for ({DirWatchTransferApp.SymbolicLinks.Count}) symbolic links", DirWatchTransferApp.StatusOfflineConfig.ImageIndex);
        }

        // this.AddHistoryItem($"Link created copy of {copyDiagnostics.SourcePath} at {copyDiagnostics.TargetPath} ({copyDiagnostics.ElapsedTime} ms)", DirWatchTransferApp.LinkImageConfig.ImageIndex);

        #endregion

        #region Callbacks

        private void OnCopyCompleted(CopyDiagnostics copyDiagnostics)
        {
            this.AddHistoryItem($"File contents synced between {copyDiagnostics.SourcePath} and {copyDiagnostics.TargetPath} ({copyDiagnostics.ElapsedTime} ms)", DirWatchTransferApp.LinkImageConfig.ImageIndex);
        }

        #endregion
    }
}