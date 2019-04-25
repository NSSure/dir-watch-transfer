using dir_watch_transfer_ui.Model;
using System;
using System.Windows.Forms;

namespace dir_watch_transfer_ui.Forms
{
    public partial class CreateSymbolicLinkForm : Form
    {
        public CreateSymbolicLinkForm()
        {
            InitializeComponent();

            btnSourceDirectory.Click += BtnSourceDirectory_Click;
            btnTargetDirectory.Click += BtnTargetDirectory_Click;
            btnCreateWatcher.Click += BtnCreateWatcher_Click;
        }

        private void BtnSourceDirectory_Click(object sender, EventArgs e)
        {
            if (sourceDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                this.Invoke((MethodInvoker)delegate {
                    txtSourceDirectory.Text = sourceDirectoryDialog.SelectedPath;
                });
            }
        }

        private void BtnTargetDirectory_Click(object sender, EventArgs e)
        {
            if (targetDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                this.Invoke((MethodInvoker)delegate {
                    txtTargetDirectory.Text = targetDirectoryDialog.SelectedPath;
                });
            }
        }

        private async void BtnCreateWatcher_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;

            if (string.IsNullOrEmpty(txtSourceDirectory.Text) || string.IsNullOrEmpty(txtTargetDirectory.Text))
            {
                MessageBox.Show(this, "A source and target directory must be specified before creating a watcher.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await mainForm.CreateSymbolicLink(new SymbolicLink()
            {
                Source = txtSourceDirectory.Text,
                Target = txtTargetDirectory.Text,
                WatchFileName = chkFileName.Checked,
                WatchDirectoryName = chkDirectoryName.Checked,
                WatchSize = chkSize.Checked,
                WatchLastWrite = chkLastWrite.Checked,
                WatchLastAccess = chkLastAccess.Checked,
                WatchCreationTime = chkCreationTime.Checked,
                WatchSecurity = chkSecurity.Checked,
                Monitor = new SymbolicLinkMonitor()
            });
        }
    }
}
