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
            this.watchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeedTestLink = new System.Windows.Forms.ToolStripMenuItem();
            this.contentSplitter = new System.Windows.Forms.SplitContainer();
            this.watchedDirs = new System.Windows.Forms.ListView();
            this.sourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listHistory = new System.Windows.Forms.ListView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemStartWatchingLink = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemForceCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitter)).BeginInit();
            this.contentSplitter.Panel1.SuspendLayout();
            this.contentSplitter.Panel2.SuspendLayout();
            this.contentSplitter.SuspendLayout();
            this.contextMenu.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1498, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddLink});
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
            this.menuItemAddLink.Text = "Add Symbolic Link";
            // 
            // watchersToolStripMenuItem
            // 
            this.watchersToolStripMenuItem.Name = "watchersToolStripMenuItem";
            this.watchersToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.watchersToolStripMenuItem.Text = "Watchers";
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSeedTestLink});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(54, 28);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // menuItemSeedTestLink
            // 
            this.menuItemSeedTestLink.Name = "menuItemSeedTestLink";
            this.menuItemSeedTestLink.Size = new System.Drawing.Size(252, 30);
            this.menuItemSeedTestLink.Text = "Seed test link";
            // 
            // contentSplitter
            // 
            this.contentSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitter.Location = new System.Drawing.Point(0, 28);
            this.contentSplitter.Margin = new System.Windows.Forms.Padding(0);
            this.contentSplitter.Name = "contentSplitter";
            this.contentSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contentSplitter.Panel1
            // 
            this.contentSplitter.Panel1.Controls.Add(this.watchedDirs);
            // 
            // contentSplitter.Panel2
            // 
            this.contentSplitter.Panel2.Controls.Add(this.listHistory);
            this.contentSplitter.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contentSplitter.Size = new System.Drawing.Size(1498, 970);
            this.contentSplitter.SplitterDistance = 444;
            this.contentSplitter.SplitterWidth = 5;
            this.contentSplitter.TabIndex = 6;
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
            this.watchedDirs.Size = new System.Drawing.Size(1498, 444);
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
            this.listHistory.Size = new System.Drawing.Size(1498, 521);
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
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1498, 998);
            this.Controls.Add(this.contentSplitter);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dir-Watch-Transfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contentSplitter.Panel1.ResumeLayout(false);
            this.contentSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitter)).EndInit();
            this.contentSplitter.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddLink;
        private System.Windows.Forms.SplitContainer contentSplitter;
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
    }
}

