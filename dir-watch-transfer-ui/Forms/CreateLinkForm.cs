using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dir_watch_transfer_ui.Forms
{
    public partial class CreateLinkForm : Form
    {
        public CreateLinkForm()
        {
            InitializeComponent();

            txtSourceDirectory.Click += TxtSourceDirectory_Click;
            txtTargetDirectory.Click += TxtTargetDirectory_Click;
            btnCreateWatcher.Click += BtnCreateWatcher_Click;
        }

        private void TxtSourceDirectory_Click(object sender, EventArgs e)
        {
            if (sourceDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                this.Invoke((MethodInvoker)delegate {
                    txtSourceDirectory.Text = sourceDirectoryDialog.SelectedPath;
                });
            }
        }

        private void TxtTargetDirectory_Click(object sender, EventArgs e)
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

            await mainForm.CreateSymbolicLink(txtSourceDirectory.Text, txtTargetDirectory.Text);
        }
    }
}
