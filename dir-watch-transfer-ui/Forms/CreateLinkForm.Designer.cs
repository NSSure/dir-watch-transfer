namespace dir_watch_transfer_ui.Forms
{
    partial class CreateLinkForm
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
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateWatcher = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sourceDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkFileName = new System.Windows.Forms.CheckBox();
            this.chkDirectoryName = new System.Windows.Forms.CheckBox();
            this.chkAttributes = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkLastWrite = new System.Windows.Forms.CheckBox();
            this.chkLastAccess = new System.Windows.Forms.CheckBox();
            this.chkCreationTime = new System.Windows.Forms.CheckBox();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(149, 37);
            this.txtTargetDirectory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(623, 32);
            this.txtTargetDirectory.TabIndex = 1;
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(149, 0);
            this.txtSourceDirectory.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.ShortcutsEnabled = false;
            this.txtSourceDirectory.Size = new System.Drawing.Size(623, 32);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target Directory";
            // 
            // btnCreateWatcher
            // 
            this.btnCreateWatcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCreateWatcher.FlatAppearance.BorderSize = 0;
            this.btnCreateWatcher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateWatcher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateWatcher.Location = new System.Drawing.Point(152, 362);
            this.btnCreateWatcher.Name = "btnCreateWatcher";
            this.btnCreateWatcher.Size = new System.Drawing.Size(617, 57);
            this.btnCreateWatcher.TabIndex = 2;
            this.btnCreateWatcher.Text = "Create Watcher";
            this.btnCreateWatcher.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtTargetDirectory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSourceDirectory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateWatcher, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 422);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkFileName);
            this.flowLayoutPanel1.Controls.Add(this.chkDirectoryName);
            this.flowLayoutPanel1.Controls.Add(this.chkAttributes);
            this.flowLayoutPanel1.Controls.Add(this.chkSize);
            this.flowLayoutPanel1.Controls.Add(this.chkLastWrite);
            this.flowLayoutPanel1.Controls.Add(this.chkLastAccess);
            this.flowLayoutPanel1.Controls.Add(this.chkCreationTime);
            this.flowLayoutPanel1.Controls.Add(this.chkSecurity);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(152, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(155, 279);
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
            this.chkDirectoryName.Location = new System.Drawing.Point(3, 33);
            this.chkDirectoryName.Name = "chkDirectoryName";
            this.chkDirectoryName.Size = new System.Drawing.Size(144, 24);
            this.chkDirectoryName.TabIndex = 1;
            this.chkDirectoryName.Text = "Directory Name";
            this.chkDirectoryName.UseVisualStyleBackColor = true;
            // 
            // chkAttributes
            // 
            this.chkAttributes.AutoSize = true;
            this.chkAttributes.Location = new System.Drawing.Point(3, 63);
            this.chkAttributes.Name = "chkAttributes";
            this.chkAttributes.Size = new System.Drawing.Size(104, 24);
            this.chkAttributes.TabIndex = 2;
            this.chkAttributes.Text = "Attributes";
            this.chkAttributes.UseVisualStyleBackColor = true;
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(3, 93);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(66, 24);
            this.chkSize.TabIndex = 3;
            this.chkSize.Text = "Size";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // chkLastWrite
            // 
            this.chkLastWrite.AutoSize = true;
            this.chkLastWrite.Location = new System.Drawing.Point(3, 123);
            this.chkLastWrite.Name = "chkLastWrite";
            this.chkLastWrite.Size = new System.Drawing.Size(107, 24);
            this.chkLastWrite.TabIndex = 4;
            this.chkLastWrite.Text = "Last Write";
            this.chkLastWrite.UseVisualStyleBackColor = true;
            // 
            // chkLastAccess
            // 
            this.chkLastAccess.AutoSize = true;
            this.chkLastAccess.Location = new System.Drawing.Point(3, 153);
            this.chkLastAccess.Name = "chkLastAccess";
            this.chkLastAccess.Size = new System.Drawing.Size(122, 24);
            this.chkLastAccess.TabIndex = 6;
            this.chkLastAccess.Text = "Last Access";
            this.chkLastAccess.UseVisualStyleBackColor = true;
            // 
            // chkCreationTime
            // 
            this.chkCreationTime.AutoSize = true;
            this.chkCreationTime.Location = new System.Drawing.Point(3, 183);
            this.chkCreationTime.Name = "chkCreationTime";
            this.chkCreationTime.Size = new System.Drawing.Size(133, 24);
            this.chkCreationTime.TabIndex = 7;
            this.chkCreationTime.Text = "Creation Time";
            this.chkCreationTime.UseVisualStyleBackColor = true;
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Location = new System.Drawing.Point(3, 213);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(92, 24);
            this.chkSecurity.TabIndex = 8;
            this.chkSecurity.Text = "Security";
            this.chkSecurity.UseVisualStyleBackColor = true;
            // 
            // CreateLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 508);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 508);
            this.Name = "CreateLinkForm";
            this.ShowIcon = false;
            this.Text = "CreateLinkForm";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateWatcher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}