namespace dir_watch_transfer_ui.Forms
{
    partial class CreateWatcher
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkAttributes = new System.Windows.Forms.CheckBox();
            this.chkLastAccess = new System.Windows.Forms.CheckBox();
            this.chkLastWrite = new System.Windows.Forms.CheckBox();
            this.chkCreationTime = new System.Windows.Forms.CheckBox();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkDirectoryName = new System.Windows.Forms.CheckBox();
            this.chkFileName = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.chkAttributes);
            this.flowLayoutPanel3.Controls.Add(this.chkLastAccess);
            this.flowLayoutPanel3.Controls.Add(this.chkLastWrite);
            this.flowLayoutPanel3.Controls.Add(this.chkCreationTime);
            this.flowLayoutPanel3.Controls.Add(this.chkSecurity);
            this.flowLayoutPanel3.Controls.Add(this.chkSize);
            this.flowLayoutPanel3.Controls.Add(this.chkDirectoryName);
            this.flowLayoutPanel3.Controls.Add(this.chkFileName);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 248);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // chkAttributes
            // 
            this.chkAttributes.AutoSize = true;
            this.chkAttributes.Location = new System.Drawing.Point(3, 3);
            this.chkAttributes.Name = "chkAttributes";
            this.chkAttributes.Size = new System.Drawing.Size(104, 24);
            this.chkAttributes.TabIndex = 2;
            this.chkAttributes.Text = "Attributes";
            this.chkAttributes.UseVisualStyleBackColor = true;
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
            // chkLastWrite
            // 
            this.chkLastWrite.AutoSize = true;
            this.chkLastWrite.Location = new System.Drawing.Point(3, 63);
            this.chkLastWrite.Name = "chkLastWrite";
            this.chkLastWrite.Size = new System.Drawing.Size(107, 24);
            this.chkLastWrite.TabIndex = 4;
            this.chkLastWrite.Text = "Last Write";
            this.chkLastWrite.UseVisualStyleBackColor = true;
            // 
            // chkCreationTime
            // 
            this.chkCreationTime.AutoSize = true;
            this.chkCreationTime.Location = new System.Drawing.Point(3, 93);
            this.chkCreationTime.Name = "chkCreationTime";
            this.chkCreationTime.Size = new System.Drawing.Size(133, 24);
            this.chkCreationTime.TabIndex = 7;
            this.chkCreationTime.Text = "Creation Time";
            this.chkCreationTime.UseVisualStyleBackColor = true;
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Location = new System.Drawing.Point(3, 123);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(92, 24);
            this.chkSecurity.TabIndex = 8;
            this.chkSecurity.Text = "Security";
            this.chkSecurity.UseVisualStyleBackColor = true;
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(3, 153);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(66, 24);
            this.chkSize.TabIndex = 3;
            this.chkSize.Text = "Size";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // chkDirectoryName
            // 
            this.chkDirectoryName.AutoSize = true;
            this.chkDirectoryName.Location = new System.Drawing.Point(3, 183);
            this.chkDirectoryName.Name = "chkDirectoryName";
            this.chkDirectoryName.Size = new System.Drawing.Size(144, 24);
            this.chkDirectoryName.TabIndex = 1;
            this.chkDirectoryName.Text = "Directory Name";
            this.chkDirectoryName.UseVisualStyleBackColor = true;
            // 
            // chkFileName
            // 
            this.chkFileName.AutoSize = true;
            this.chkFileName.Location = new System.Drawing.Point(3, 213);
            this.chkFileName.Name = "chkFileName";
            this.chkFileName.Size = new System.Drawing.Size(106, 24);
            this.chkFileName.TabIndex = 0;
            this.chkFileName.Text = "File Name";
            this.chkFileName.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Watcher";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // mainContainer
            // 
            this.mainContainer.AutoSize = true;
            this.mainContainer.Controls.Add(this.flowLayoutPanel3);
            this.mainContainer.Controls.Add(this.btnSave);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(5);
            this.mainContainer.Size = new System.Drawing.Size(778, 544);
            this.mainContainer.TabIndex = 8;
            // 
            // CreateWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.mainContainer);
            this.Name = "CreateWatcher";
            this.Text = "Manage Symbolic Link Watcher";
            this.Load += new System.EventHandler(this.CreateWatcher_Load);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkAttributes;
        private System.Windows.Forms.CheckBox chkLastAccess;
        private System.Windows.Forms.CheckBox chkLastWrite;
        private System.Windows.Forms.CheckBox chkCreationTime;
        private System.Windows.Forms.CheckBox chkSecurity;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.CheckBox chkDirectoryName;
        private System.Windows.Forms.CheckBox chkFileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel mainContainer;
    }
}