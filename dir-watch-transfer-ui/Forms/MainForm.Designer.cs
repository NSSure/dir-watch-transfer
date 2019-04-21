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
            this.sourceDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddLink = new System.Windows.Forms.ToolStripMenuItem();
            this.watchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStartWatchers = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeedTestLink = new System.Windows.Forms.ToolStripMenuItem();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.watchedDirs = new System.Windows.Forms.ListView();
            this.sourceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.force = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.btnCreateWatcher = new System.Windows.Forms.Button();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemForceCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.watchersToolStripMenuItem,
            this.devToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1498, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddLink});
            this.menu.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(46, 29);
            this.menu.Text = "File";
            // 
            // menuItemAddLink
            // 
            this.menuItemAddLink.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemAddLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuItemAddLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItemAddLink.Name = "menuItemAddLink";
            this.menuItemAddLink.Size = new System.Drawing.Size(252, 30);
            this.menuItemAddLink.Text = "Add Link";
            // 
            // watchersToolStripMenuItem
            // 
            this.watchersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStartWatchers});
            this.watchersToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchersToolStripMenuItem.Name = "watchersToolStripMenuItem";
            this.watchersToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.watchersToolStripMenuItem.Text = "Watchers";
            // 
            // menuItemStartWatchers
            // 
            this.menuItemStartWatchers.Name = "menuItemStartWatchers";
            this.menuItemStartWatchers.Size = new System.Drawing.Size(244, 30);
            this.menuItemStartWatchers.Text = "Start existing watchers";
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSeedTestLink});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // menuItemSeedTestLink
            // 
            this.menuItemSeedTestLink.Name = "menuItemSeedTestLink";
            this.menuItemSeedTestLink.Size = new System.Drawing.Size(201, 30);
            this.menuItemSeedTestLink.Text = "Seed test link";
            // 
            // listHistory
            // 
            this.listHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listHistory.ItemHeight = 20;
            this.listHistory.Location = new System.Drawing.Point(3, 0);
            this.listHistory.Margin = new System.Windows.Forms.Padding(0);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(1463, 404);
            this.listHistory.TabIndex = 5;
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.Location = new System.Drawing.Point(12, 91);
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
            this.mainContainer.Size = new System.Drawing.Size(1474, 830);
            this.mainContainer.SplitterDistance = 414;
            this.mainContainer.TabIndex = 6;
            // 
            // watchedDirs
            // 
            this.watchedDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watchedDirs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sourceColumn,
            this.targetColumn,
            this.status,
            this.progress,
            this.force});
            this.watchedDirs.FullRowSelect = true;
            this.watchedDirs.Location = new System.Drawing.Point(3, 3);
            this.watchedDirs.Name = "watchedDirs";
            this.watchedDirs.Size = new System.Drawing.Size(1463, 408);
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
            // progress
            // 
            this.progress.Text = "Progress";
            // 
            // force
            // 
            this.force.Text = "Force";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(5, 5);
            this.txtSourceDirectory.Margin = new System.Windows.Forms.Padding(5);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.ReadOnly = true;
            this.txtSourceDirectory.ShortcutsEnabled = false;
            this.txtSourceDirectory.Size = new System.Drawing.Size(384, 26);
            this.txtSourceDirectory.TabIndex = 1;
            this.txtSourceDirectory.Text = "Select source directory";
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(399, 5);
            this.txtTargetDirectory.Margin = new System.Windows.Forms.Padding(5);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.ReadOnly = true;
            this.txtTargetDirectory.Size = new System.Drawing.Size(771, 26);
            this.txtTargetDirectory.TabIndex = 1;
            // 
            // btnCreateWatcher
            // 
            this.btnCreateWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateWatcher.FlatAppearance.BorderSize = 0;
            this.btnCreateWatcher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateWatcher.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateWatcher.Location = new System.Drawing.Point(1180, 5);
            this.btnCreateWatcher.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateWatcher.Name = "btnCreateWatcher";
            this.btnCreateWatcher.Size = new System.Drawing.Size(287, 26);
            this.btnCreateWatcher.TabIndex = 2;
            this.btnCreateWatcher.Text = "Create Watcher";
            this.btnCreateWatcher.UseVisualStyleBackColor = true;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextItemForceCopy});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(172, 34);
            // 
            // contextItemForceCopy
            // 
            this.contextItemForceCopy.Name = "contextItemForceCopy";
            this.contextItemForceCopy.Size = new System.Drawing.Size(240, 30);
            this.contextItemForceCopy.Text = "Force copy";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtSourceDirectory);
            this.flowLayoutPanel1.Controls.Add(this.txtTargetDirectory);
            this.flowLayoutPanel1.Controls.Add(this.btnCreateWatcher);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1474, 37);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1498, 933);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dir-Watch-Transfer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog sourceDirectoryDialog;
        private System.Windows.Forms.FolderBrowserDialog targetDirectoryDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddLink;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.ListView watchedDirs;
        private System.Windows.Forms.ColumnHeader sourceColumn;
        private System.Windows.Forms.ColumnHeader targetColumn;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Button btnCreateWatcher;
        private System.Windows.Forms.ToolStripMenuItem watchersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemStartWatchers;
        private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSeedTestLink;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextItemForceCopy;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader force;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

