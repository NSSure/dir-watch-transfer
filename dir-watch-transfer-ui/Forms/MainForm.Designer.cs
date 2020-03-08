﻿namespace dir_watch_transfer_ui
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
            this.startWatchers = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchers = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemStartWatchingLink = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemForceCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.createLinkWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listHistory = new System.Windows.Forms.ListView();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.managementTab = new System.Windows.Forms.TabPage();
            this.sessionHistoryTab = new System.Windows.Forms.TabPage();
            this.symbolicLinkSyncColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enabledColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduledColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastSyncColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.intervalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listSyncs = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.symbolicLinkColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listWatchers = new System.Windows.Forms.ListView();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.statColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.managementTab.SuspendLayout();
            this.sessionHistoryTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1498, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddLink,
            this.exitToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(55, 25);
            this.menu.Text = "File";
            // 
            // menuItemAddLink
            // 
            this.menuItemAddLink.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemAddLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuItemAddLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItemAddLink.Name = "menuItemAddLink";
            this.menuItemAddLink.Size = new System.Drawing.Size(270, 34);
            this.menuItemAddLink.Text = "Create symbolic link";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // watchersToolStripMenuItem
            // 
            this.watchersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWatchers,
            this.stopWatchers});
            this.watchersToolStripMenuItem.Name = "watchersToolStripMenuItem";
            this.watchersToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.watchersToolStripMenuItem.Text = "Watchers";
            // 
            // startWatchers
            // 
            this.startWatchers.Name = "startWatchers";
            this.startWatchers.Size = new System.Drawing.Size(225, 34);
            this.startWatchers.Text = "Start watchers";
            // 
            // stopWatchers
            // 
            this.stopWatchers.Enabled = false;
            this.stopWatchers.Name = "stopWatchers";
            this.stopWatchers.Size = new System.Drawing.Size(225, 34);
            this.stopWatchers.Text = "Stop watchers";
            // 
            // syncsToolStripMenuItem
            // 
            this.syncsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSyncToolStripMenuItem});
            this.syncsToolStripMenuItem.Name = "syncsToolStripMenuItem";
            this.syncsToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.syncsToolStripMenuItem.Text = "Syncs";
            // 
            // createSyncToolStripMenuItem
            // 
            this.createSyncToolStripMenuItem.Name = "createSyncToolStripMenuItem";
            this.createSyncToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.createSyncToolStripMenuItem.Text = "Create sync";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.versionToolStripMenuItem.Text = "Check for updates";
            // 
            // versionToolStripMenuItem1
            // 
            this.versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            this.versionToolStripMenuItem1.Size = new System.Drawing.Size(256, 34);
            this.versionToolStripMenuItem1.Text = "Version";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.sourceToolStripMenuItem.Text = "Source";
            // 
            // listSymbolicLinks
            // 
            this.listSymbolicLinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.sourceColumn,
            this.targetColumn,
            this.statColumn});
            this.listSymbolicLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSymbolicLinks.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSymbolicLinks.FullRowSelect = true;
            this.listSymbolicLinks.HideSelection = false;
            this.listSymbolicLinks.Location = new System.Drawing.Point(3, 3);
            this.listSymbolicLinks.Name = "listSymbolicLinks";
            this.listSymbolicLinks.Size = new System.Drawing.Size(1484, 447);
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
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextItemStartWatchingLink,
            this.contextItemForceCopy,
            this.createLinkWatcherToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(229, 100);
            // 
            // contextItemStartWatchingLink
            // 
            this.contextItemStartWatchingLink.Name = "contextItemStartWatchingLink";
            this.contextItemStartWatchingLink.Size = new System.Drawing.Size(228, 32);
            this.contextItemStartWatchingLink.Text = "Start watching link";
            // 
            // contextItemForceCopy
            // 
            this.contextItemForceCopy.Name = "contextItemForceCopy";
            this.contextItemForceCopy.Size = new System.Drawing.Size(228, 32);
            this.contextItemForceCopy.Text = "Force copy";
            // 
            // createLinkWatcherToolStripMenuItem
            // 
            this.createLinkWatcherToolStripMenuItem.Name = "createLinkWatcherToolStripMenuItem";
            this.createLinkWatcherToolStripMenuItem.Size = new System.Drawing.Size(228, 32);
            this.createLinkWatcherToolStripMenuItem.Text = "Create as watcher";
            // 
            // listHistory
            // 
            this.listHistory.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHistory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistory.FullRowSelect = true;
            this.listHistory.HideSelection = false;
            this.listHistory.Location = new System.Drawing.Point(3, 3);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(1484, 447);
            this.listHistory.TabIndex = 7;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.List;
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.managementTab);
            this.mainTabs.Controls.Add(this.sessionHistoryTab);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1498, 486);
            this.mainTabs.TabIndex = 1;
            // 
            // managementTab
            // 
            this.managementTab.Controls.Add(this.listSymbolicLinks);
            this.managementTab.Location = new System.Drawing.Point(4, 29);
            this.managementTab.Name = "managementTab";
            this.managementTab.Padding = new System.Windows.Forms.Padding(3);
            this.managementTab.Size = new System.Drawing.Size(1490, 453);
            this.managementTab.TabIndex = 0;
            this.managementTab.Text = "Management";
            this.managementTab.UseVisualStyleBackColor = true;
            // 
            // sessionHistoryTab
            // 
            this.sessionHistoryTab.Controls.Add(this.listHistory);
            this.sessionHistoryTab.Location = new System.Drawing.Point(4, 29);
            this.sessionHistoryTab.Name = "sessionHistoryTab";
            this.sessionHistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.sessionHistoryTab.Size = new System.Drawing.Size(1490, 453);
            this.sessionHistoryTab.TabIndex = 1;
            this.sessionHistoryTab.Text = "Session History";
            this.sessionHistoryTab.UseVisualStyleBackColor = true;
            // 
            // symbolicLinkSyncColumn
            // 
            this.symbolicLinkSyncColumn.DisplayIndex = 0;
            this.symbolicLinkSyncColumn.Text = "Symbolic Link";
            this.symbolicLinkSyncColumn.Width = 121;
            // 
            // enabledColumn
            // 
            this.enabledColumn.DisplayIndex = 1;
            this.enabledColumn.Text = "Enabled";
            this.enabledColumn.Width = 216;
            // 
            // scheduledColumn
            // 
            this.scheduledColumn.DisplayIndex = 2;
            this.scheduledColumn.Text = "Scheduled";
            this.scheduledColumn.Width = 142;
            // 
            // lastSyncColumn
            // 
            this.lastSyncColumn.DisplayIndex = 3;
            this.lastSyncColumn.Text = "Last Sync";
            this.lastSyncColumn.Width = 121;
            // 
            // intervalColumn
            // 
            this.intervalColumn.DisplayIndex = 4;
            this.intervalColumn.Text = "Interval";
            this.intervalColumn.Width = 193;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listSyncs);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1490, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Syncs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listSyncs
            // 
            this.listSyncs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSyncs.HideSelection = false;
            this.listSyncs.Location = new System.Drawing.Point(3, 3);
            this.listSyncs.Name = "listSyncs";
            this.listSyncs.Size = new System.Drawing.Size(1484, 444);
            this.listSyncs.TabIndex = 0;
            this.listSyncs.UseCompatibleStateImageBehavior = false;
            this.listSyncs.View = System.Windows.Forms.View.Details;
            this.listSyncs.SelectedIndexChanged += new System.EventHandler(this.ListSyncs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listWatchers);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1490, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Watchers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1498, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // symbolicLinkColumn
            // 
            this.symbolicLinkColumn.Text = "Symbolic Link";
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            // 
            // listWatchers
            // 
            this.listWatchers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.symbolicLinkColumn,
            this.statusColumn});
            this.listWatchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWatchers.HideSelection = false;
            this.listWatchers.Location = new System.Drawing.Point(3, 3);
            this.listWatchers.Name = "listWatchers";
            this.listWatchers.Size = new System.Drawing.Size(1484, 444);
            this.listWatchers.TabIndex = 0;
            this.listWatchers.UseCompatibleStateImageBehavior = false;
            this.listWatchers.View = System.Windows.Forms.View.Details;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 25);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mainTabs);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tabControl1);
            this.mainSplitContainer.Size = new System.Drawing.Size(1498, 973);
            this.mainSplitContainer.SplitterDistance = 486;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // statColumn
            // 
            this.statColumn.Text = "Status";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1498, 998);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DirWatchTransfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.managementTab.ResumeLayout(false);
            this.sessionHistoryTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem contextItemForceCopy;
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
        private System.Windows.Forms.ToolStripMenuItem startWatchers;
        private System.Windows.Forms.ToolStripMenuItem stopWatchers;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage managementTab;
        private System.Windows.Forms.TabPage sessionHistoryTab;
        private System.Windows.Forms.ColumnHeader symbolicLinkSyncColumn;
        private System.Windows.Forms.ColumnHeader enabledColumn;
        private System.Windows.Forms.ColumnHeader scheduledColumn;
        private System.Windows.Forms.ColumnHeader lastSyncColumn;
        private System.Windows.Forms.ColumnHeader intervalColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listSyncs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView listWatchers;
        private System.Windows.Forms.ColumnHeader symbolicLinkColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ColumnHeader statColumn;
    }
}

