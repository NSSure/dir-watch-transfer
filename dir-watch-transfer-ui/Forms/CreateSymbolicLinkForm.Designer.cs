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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkFileName = new System.Windows.Forms.CheckBox();
            this.chkDirectoryName = new System.Windows.Forms.CheckBox();
            this.chkAttributes = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkLastWrite = new System.Windows.Forms.CheckBox();
            this.chkLastAccess = new System.Windows.Forms.CheckBox();
            this.chkCreationTime = new System.Windows.Forms.CheckBox();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.sourceDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnSourceDirectory = new System.Windows.Forms.Button();
            this.btnTargetDirectory = new System.Windows.Forms.Button();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateWatcher
            // 
            this.btnCreateWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.btnCreateWatcher, 2);
            this.btnCreateWatcher.FlatAppearance.BorderSize = 0;
            this.btnCreateWatcher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateWatcher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateWatcher.Location = new System.Drawing.Point(136, 150);
            this.btnCreateWatcher.Name = "btnCreateWatcher";
            this.btnCreateWatcher.Size = new System.Drawing.Size(636, 30);
            this.btnCreateWatcher.TabIndex = 2;
            this.btnCreateWatcher.Text = "Create Watcher";
            this.btnCreateWatcher.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.chkFileName);
            this.flowLayoutPanel1.Controls.Add(this.chkDirectoryName);
            this.flowLayoutPanel1.Controls.Add(this.chkAttributes);
            this.flowLayoutPanel1.Controls.Add(this.chkSize);
            this.flowLayoutPanel1.Controls.Add(this.chkLastWrite);
            this.flowLayoutPanel1.Controls.Add(this.chkLastAccess);
            this.flowLayoutPanel1.Controls.Add(this.chkCreationTime);
            this.flowLayoutPanel1.Controls.Add(this.chkSecurity);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 65);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // chkFileName
            // 
            this.chkFileName.AutoSize = true;
            this.chkFileName.Location = new System.Drawing.Point(3, 3);
            this.chkFileName.Name = "chkFileName";
            this.chkFileName.Size = new System.Drawing.Size(106, 24);
            this.chkFileName.TabIndex = 0;
            this.chkFileName.Text = "File Name";
            this.chkFileName.UseVisualStyleBackColor = true;
            // 
            // chkDirectoryName
            // 
            this.chkDirectoryName.AutoSize = true;
            this.chkDirectoryName.Location = new System.Drawing.Point(115, 3);
            this.chkDirectoryName.Name = "chkDirectoryName";
            this.chkDirectoryName.Size = new System.Drawing.Size(144, 24);
            this.chkDirectoryName.TabIndex = 1;
            this.chkDirectoryName.Text = "Directory Name";
            this.chkDirectoryName.UseVisualStyleBackColor = true;
            // 
            // chkAttributes
            // 
            this.chkAttributes.AutoSize = true;
            this.chkAttributes.Location = new System.Drawing.Point(265, 3);
            this.chkAttributes.Name = "chkAttributes";
            this.chkAttributes.Size = new System.Drawing.Size(104, 24);
            this.chkAttributes.TabIndex = 2;
            this.chkAttributes.Text = "Attributes";
            this.chkAttributes.UseVisualStyleBackColor = true;
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(375, 3);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(66, 24);
            this.chkSize.TabIndex = 3;
            this.chkSize.Text = "Size";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // chkLastWrite
            // 
            this.chkLastWrite.AutoSize = true;
            this.chkLastWrite.Location = new System.Drawing.Point(447, 3);
            this.chkLastWrite.Name = "chkLastWrite";
            this.chkLastWrite.Size = new System.Drawing.Size(107, 24);
            this.chkLastWrite.TabIndex = 4;
            this.chkLastWrite.Text = "Last Write";
            this.chkLastWrite.UseVisualStyleBackColor = true;
            // 
            // chkLastAccess
            // 
            this.chkLastAccess.AutoSize = true;
            this.chkLastAccess.Location = new System.Drawing.Point(3, 33);
            this.chkLastAccess.Name = "chkLastAccess";
            this.chkLastAccess.Size = new System.Drawing.Size(122, 24);
            this.chkLastAccess.TabIndex = 6;
            this.chkLastAccess.Text = "Last Access";
            this.chkLastAccess.UseVisualStyleBackColor = true;
            // 
            // chkCreationTime
            // 
            this.chkCreationTime.AutoSize = true;
            this.chkCreationTime.Location = new System.Drawing.Point(131, 33);
            this.chkCreationTime.Name = "chkCreationTime";
            this.chkCreationTime.Size = new System.Drawing.Size(133, 24);
            this.chkCreationTime.TabIndex = 7;
            this.chkCreationTime.Text = "Creation Time";
            this.chkCreationTime.UseVisualStyleBackColor = true;
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Location = new System.Drawing.Point(270, 33);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(92, 24);
            this.chkSecurity.TabIndex = 8;
            this.chkSecurity.Text = "Security";
            this.chkSecurity.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 196);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSourceDirectory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSourceDirectory, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSourceDirectory, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTargetDirectory, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTargetDirectory, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateWatcher, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(775, 187);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Target Directory";
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Location = new System.Drawing.Point(3, 8);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(127, 20);
            this.lblSourceDirectory.TabIndex = 0;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(136, 3);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(595, 30);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // btnSourceDirectory
            // 
            this.btnSourceDirectory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSourceDirectory.Location = new System.Drawing.Point(737, 3);
            this.btnSourceDirectory.Name = "btnSourceDirectory";
            this.btnSourceDirectory.Size = new System.Drawing.Size(35, 30);
            this.btnSourceDirectory.TabIndex = 2;
            this.btnSourceDirectory.Text = "...";
            this.btnSourceDirectory.UseVisualStyleBackColor = true;
            // 
            // btnTargetDirectory
            // 
            this.btnTargetDirectory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTargetDirectory.Location = new System.Drawing.Point(737, 39);
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
            this.txtTargetDirectory.Location = new System.Drawing.Point(136, 39);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(595, 30);
            this.txtTargetDirectory.TabIndex = 4;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // CreateSymbolicLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.checkedListBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateSymbolicLinkForm";
            this.ShowIcon = false;
            this.Text = "CreateLinkForm";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateWatcher;
        private System.Windows.Forms.FolderBrowserDialog sourceDirectoryDialog;
        private System.Windows.Forms.FolderBrowserDialog targetDirectoryDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkFileName;
        private System.Windows.Forms.CheckBox chkDirectoryName;
        private System.Windows.Forms.CheckBox chkAttributes;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.CheckBox chkLastWrite;
        private System.Windows.Forms.CheckBox chkLastAccess;
        private System.Windows.Forms.CheckBox chkCreationTime;
        private System.Windows.Forms.CheckBox chkSecurity;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button btnSourceDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTargetDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}