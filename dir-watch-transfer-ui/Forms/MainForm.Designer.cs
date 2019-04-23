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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddLink = new System.Windows.Forms.ToolStripMenuItem();
            this.watchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeedTestLink = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.watchedDirs = new System.Windows.Forms.ListView();
            this.sourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHistory = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemStartWatchingLink = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemForceCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressCopy = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.devToolStripMenuItem});
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
            this.menuItemAddLink});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(51, 25);
            this.menu.Text = "File";
            // 
            // menuItemAddLink
            // 
            this.menuItemAddLink.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemAddLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuItemAddLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItemAddLink.Name = "menuItemAddLink";
            this.menuItemAddLink.Size = new System.Drawing.Size(161, 30);
            this.menuItemAddLink.Text = "Add Link";
            // 
            // watchersToolStripMenuItem
            // 
            this.watchersToolStripMenuItem.Name = "watchersToolStripMenuItem";
            this.watchersToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.watchersToolStripMenuItem.Text = "Watchers";
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSeedTestLink});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // menuItemSeedTestLink
            // 
            this.menuItemSeedTestLink.Name = "menuItemSeedTestLink";
            this.menuItemSeedTestLink.Size = new System.Drawing.Size(200, 30);
            this.menuItemSeedTestLink.Text = "Seed test link";
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.watchedDirs);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.listHistory);
            this.mainContainer.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainContainer.Size = new System.Drawing.Size(1498, 930);
            this.mainContainer.SplitterDistance = 428;
            this.mainContainer.SplitterWidth = 5;
            this.mainContainer.TabIndex = 6;
            // 
            // watchedDirs
            // 
            this.watchedDirs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sourceColumn,
            this.targetColumn,
            this.status});
            this.watchedDirs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchedDirs.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchedDirs.FullRowSelect = true;
            this.watchedDirs.Location = new System.Drawing.Point(0, 0);
            this.watchedDirs.Name = "watchedDirs";
            this.watchedDirs.Size = new System.Drawing.Size(1498, 428);
            this.watchedDirs.TabIndex = 0;
            this.watchedDirs.TileSize = new System.Drawing.Size(268, 44);
            this.watchedDirs.UseCompatibleStateImageBehavior = false;
            this.watchedDirs.View = System.Windows.Forms.View.Details;
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
            // status
            // 
            this.status.Text = "Status";
            // 
            // listHistory
            // 
            this.listHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHistory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistory.FullRowSelect = true;
            this.listHistory.Location = new System.Drawing.Point(0, 0);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(1498, 497);
            this.listHistory.TabIndex = 7;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.List;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextItemStartWatchingLink,
            this.contextItemForceCopy});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(229, 64);
            // 
            // contextItemStartWatchingLink
            // 
            this.contextItemStartWatchingLink.Name = "contextItemStartWatchingLink";
            this.contextItemStartWatchingLink.Size = new System.Drawing.Size(228, 30);
            this.contextItemStartWatchingLink.Text = "Start watching link";
            // 
            // contextItemForceCopy
            // 
            this.contextItemForceCopy.Name = "contextItemForceCopy";
            this.contextItemForceCopy.Size = new System.Drawing.Size(228, 30);
            this.contextItemForceCopy.Text = "Force copy";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressCopy);
            this.splitContainer1.Size = new System.Drawing.Size(1498, 973);
            this.splitContainer1.SplitterDistance = 930;
            this.splitContainer1.TabIndex = 7;
            // 
            // progressCopy
            // 
            this.progressCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressCopy.Location = new System.Drawing.Point(0, 0);
            this.progressCopy.Name = "progressCopy";
            this.progressCopy.Size = new System.Drawing.Size(1498, 39);
            this.progressCopy.TabIndex = 0;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1498, 998);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dir-Watch-Transfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddLink;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ListView watchedDirs;
        private System.Windows.Forms.ColumnHeader sourceColumn;
        private System.Windows.Forms.ColumnHeader targetColumn;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ToolStripMenuItem watchersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSeedTestLink;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextItemStartWatchingLink;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.ToolStripMenuItem contextItemForceCopy;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar progressCopy;
    }
}

