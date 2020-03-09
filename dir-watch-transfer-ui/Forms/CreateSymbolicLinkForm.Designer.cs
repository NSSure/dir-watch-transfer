namespace dir_watch_transfer_ui.Forms
{
    partial class CreateSymbolicLinkForm
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
            this.btnCreateWatcher = new System.Windows.Forms.Button();
            this.sourceDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnSourceDirectory = new System.Windows.Forms.Button();
            this.btnTargetDirectory = new System.Windows.Forms.Button();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateWatcher
            // 
            this.btnCreateWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateWatcher.AutoSize = true;
            this.btnCreateWatcher.FlatAppearance.BorderSize = 0;
            this.btnCreateWatcher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateWatcher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateWatcher.Location = new System.Drawing.Point(8, 132);
            this.btnCreateWatcher.Name = "btnCreateWatcher";
            this.btnCreateWatcher.Size = new System.Drawing.Size(758, 30);
            this.btnCreateWatcher.TabIndex = 2;
            this.btnCreateWatcher.Text = "Create Watcher";
            this.btnCreateWatcher.UseVisualStyleBackColor = true;
            this.btnCreateWatcher.Click += new System.EventHandler(this.btnCreateWatcher_Click_1);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 196);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(758, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Target Directory";
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Location = new System.Drawing.Point(8, 5);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(758, 20);
            this.lblSourceDirectory.TabIndex = 0;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(3, 3);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(595, 30);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // btnSourceDirectory
            // 
            this.btnSourceDirectory.Location = new System.Drawing.Point(604, 3);
            this.btnSourceDirectory.Name = "btnSourceDirectory";
            this.btnSourceDirectory.Size = new System.Drawing.Size(35, 30);
            this.btnSourceDirectory.TabIndex = 2;
            this.btnSourceDirectory.Text = "...";
            this.btnSourceDirectory.UseVisualStyleBackColor = true;
            // 
            // btnTargetDirectory
            // 
            this.btnTargetDirectory.Location = new System.Drawing.Point(609, 3);
            this.btnTargetDirectory.Name = "btnTargetDirectory";
            this.btnTargetDirectory.Size = new System.Drawing.Size(35, 30);
            this.btnTargetDirectory.TabIndex = 5;
            this.btnTargetDirectory.Text = "...";
            this.btnTargetDirectory.UseVisualStyleBackColor = true;
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDirectory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(3, 3);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(600, 30);
            this.txtTargetDirectory.TabIndex = 4;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblSourceDirectory);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.btnCreateWatcher);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(778, 544);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.txtSourceDirectory);
            this.flowLayoutPanel4.Controls.Add(this.btnSourceDirectory);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(8, 28);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(758, 36);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.txtTargetDirectory);
            this.flowLayoutPanel6.Controls.Add(this.btnTargetDirectory);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(8, 90);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(758, 36);
            this.flowLayoutPanel6.TabIndex = 14;
            // 
            // CreateSymbolicLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.checkedListBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateSymbolicLinkForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Symbolic Link";
            this.TopMost = true;
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateWatcher;
        private System.Windows.Forms.FolderBrowserDialog sourceDirectoryDialog;
        private System.Windows.Forms.FolderBrowserDialog targetDirectoryDialog;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button btnSourceDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTargetDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
    }
}