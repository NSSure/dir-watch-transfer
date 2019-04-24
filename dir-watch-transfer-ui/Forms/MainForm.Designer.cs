namespace dir_watch_transfer_ui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddLink = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listSymbolicLinks = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHistory = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemStartWatchingLink = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemForceCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.createLinkWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitContent = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listWatchers = new System.Windows.Forms.ListView();
            this.symbolicLinkColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSyncs = new System.Windows.Forms.ListView();
            this.symbolicLinkSyncColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enabledColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduledColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastSyncColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.intervalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startWatchers = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).BeginInit();
            this.splitContent.Panel1.SuspendLayout();
            this.splitContent.Panel2.SuspendLayout();
            this.splitContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.watchersToolStripMenuItem,
            this.syncsToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1498, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddLink,
            this.exitToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(51, 28);
            this.menu.Text = "File";
            // 
            // menuItemAddLink
            // 
            this.menuItemAddLink.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemAddLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuItemAddLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItemAddLink.Name = "menuItemAddLink";
            this.menuItemAddLink.Size = new System.Drawing.Size(252, 30);
            this.menuItemAddLink.Text = "Create symbolic link";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // watchersToolStripMenuItem
            // 
            this.watchersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWatchers,
            this.stopWatchers});
            this.watchersToolStripMenuItem.Name = "watchersToolStripMenuItem";
            this.watchersToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.watchersToolStripMenuItem.Text = "Watchers";
            // 
            // syncsToolStripMenuItem
            // 
            this.syncsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSyncToolStripMenuItem});
            this.syncsToolStripMenuItem.Name = "syncsToolStripMenuItem";
            this.syncsToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.syncsToolStripMenuItem.Text = "Syncs";
            // 
            // createSyncToolStripMenuItem
            // 
            this.createSyncToolStripMenuItem.Name = "createSyncToolStripMenuItem";
            this.createSyncToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.createSyncToolStripMenuItem.Text = "Create sync";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.versionToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.sourceToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.versionToolStripMenuItem.Text = "Check for updates";
            // 
            // versionToolStripMenuItem1
            // 
            this.versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            this.versionToolStripMenuItem1.Size = new System.Drawing.Size(238, 30);
            this.versionToolStripMenuItem1.Text = "Version";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.sourceToolStripMenuItem.Text = "Source";
            // 
            // listSymbolicLinks
            // 
            this.listSymbolicLinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.sourceColumn,
            this.targetColumn});
            this.listSymbolicLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSymbolicLinks.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSymbolicLinks.FullRowSelect = true;
            this.listSymbolicLinks.Location = new System.Drawing.Point(0, 0);
            this.listSymbolicLinks.Name = "listSymbolicLinks";
            this.listSymbolicLinks.Size = new System.Drawing.Size(1050, 398);
            this.listSymbolicLinks.TabIndex = 0;
            this.listSymbolicLinks.TileSize = new System.Drawing.Size(268, 44);
            this.listSymbolicLinks.UseCompatibleStateImageBehavior = false;
            this.listSymbolicLinks.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // sourceColumn
            // 
            this.sourceColumn.Text = "Source";
            this.sourceColumn.Width = 63;
            // 
            // targetColumn
            // 
            this.targetColumn.Text = "Target";
            this.targetColumn.Width = 58;
            // 
            // listHistory
            // 
            this.listHistory.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHistory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistory.FullRowSelect = true;
            this.listHistory.Location = new System.Drawing.Point(0, 0);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(444, 970);
            this.listHistory.TabIndex = 7;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.List;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextItemStartWatchingLink,
            this.contextItemForceCopy,
            this.createLinkWatcherToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(233, 94);
            // 
            // contextItemStartWatchingLink
            // 
            this.contextItemStartWatchingLink.Name = "contextItemStartWatchingLink";
            this.contextItemStartWatchingLink.Size = new System.Drawing.Size(232, 30);
            this.contextItemStartWatchingLink.Text = "Start watching link";
            // 
            // contextItemForceCopy
            // 
            this.contextItemForceCopy.Name = "contextItemForceCopy";
            this.contextItemForceCopy.Size = new System.Drawing.Size(232, 30);
            this.contextItemForceCopy.Text = "Force copy";
            // 
            // createLinkWatcherToolStripMenuItem
            // 
            this.createLinkWatcherToolStripMenuItem.Name = "createLinkWatcherToolStripMenuItem";
            this.createLinkWatcherToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.createLinkWatcherToolStripMenuItem.Text = "Create link watcher";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitContent);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.listHistory);
            this.splitMain.Size = new System.Drawing.Size(1498, 970);
            this.splitMain.SplitterDistance = 1050;
            this.splitMain.TabIndex = 8;
            // 
            // splitContent
            // 
            this.splitContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContent.Location = new System.Drawing.Point(0, 0);
            this.splitContent.Name = "splitContent";
            this.splitContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContent.Panel1
            // 
            this.splitContent.Panel1.Controls.Add(this.listSymbolicLinks);
            // 
            // splitContent.Panel2
            // 
            this.splitContent.Panel2.Controls.Add(this.tabControl1);
            this.splitContent.Size = new System.Drawing.Size(1050, 970);
            this.splitContent.SplitterDistance = 398;
            this.splitContent.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listWatchers);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Watchers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listSyncs);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Syncs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listWatchers
            // 
            this.listWatchers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.symbolicLinkColumn,
            this.statusColumn});
            this.listWatchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWatchers.Location = new System.Drawing.Point(3, 3);
            this.listWatchers.Name = "listWatchers";
            this.listWatchers.Size = new System.Drawing.Size(1036, 530);
            this.listWatchers.TabIndex = 0;
            this.listWatchers.UseCompatibleStateImageBehavior = false;
            this.listWatchers.View = System.Windows.Forms.View.Details;
            // 
            // symbolicLinkColumn
            // 
            this.symbolicLinkColumn.Text = "Symbolic Link";
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            // 
            // listSyncs
            // 
            this.listSyncs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.symbolicLinkSyncColumn,
            this.enabledColumn,
            this.scheduledColumn,
            this.lastSyncColumn,
            this.intervalColumn});
            this.listSyncs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSyncs.Location = new System.Drawing.Point(3, 3);
            this.listSyncs.Name = "listSyncs";
            this.listSyncs.Size = new System.Drawing.Size(1036, 529);
            this.listSyncs.TabIndex = 0;
            this.listSyncs.UseCompatibleStateImageBehavior = false;
            this.listSyncs.View = System.Windows.Forms.View.Details;
            // 
            // symbolicLinkSyncColumn
            // 
            this.symbolicLinkSyncColumn.Text = "Symbolic Link";
            // 
            // enabledColumn
            // 
            this.enabledColumn.Text = "Enabled";
            // 
            // scheduledColumn
            // 
            this.scheduledColumn.Text = "Scheduled";
            // 
            // lastSyncColumn
            // 
            this.lastSyncColumn.Text = "Last Sync";
            // 
            // intervalColumn
            // 
            this.intervalColumn.Text = "Interval";
            // 
            // startWatchers
            // 
            this.startWatchers.Name = "startWatchers";
            this.startWatchers.Size = new System.Drawing.Size(252, 30);
            this.startWatchers.Text = "Start watchers";
            // 
            // stopWatchers
            // 
            this.stopWatchers.Enabled = false;
            this.stopWatchers.Name = "stopWatchers";
            this.stopWatchers.Size = new System.Drawing.Size(252, 30);
            this.stopWatchers.Text = "Stop watchers";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1498, 998);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dir-Watch-Transfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.splitContent.Panel1.ResumeLayout(false);
            this.splitContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).EndInit();
            this.splitContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddLink;
        private System.Windows.Forms.ListView listSymbolicLinks;
        private System.Windows.Forms.ColumnHeader sourceColumn;
        private System.Windows.Forms.ColumnHeader targetColumn;
        private System.Windows.Forms.ToolStripMenuItem watchersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextItemStartWatchingLink;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.ToolStripMenuItem contextItemForceCopy;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem createLinkWatcherToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ToolStripMenuItem syncsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ListView listWatchers;
        private System.Windows.Forms.ColumnHeader symbolicLinkColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ListView listSyncs;
        private System.Windows.Forms.ColumnHeader symbolicLinkSyncColumn;
        private System.Windows.Forms.ColumnHeader enabledColumn;
        private System.Windows.Forms.ColumnHeader scheduledColumn;
        private System.Windows.Forms.ColumnHeader lastSyncColumn;
        private System.Windows.Forms.ColumnHeader intervalColumn;
        private System.Windows.Forms.ToolStripMenuItem startWatchers;
        private System.Windows.Forms.ToolStripMenuItem stopWatchers;
    }
}

