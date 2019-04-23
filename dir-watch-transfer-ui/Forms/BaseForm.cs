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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void AutoSizeColumns(ListView listView)
        {
            int width = (listView.Width / 3);

            listView.Columns[0].Width = width;
            listView.Columns[1].Width = width;
            listView.Columns[2].Width = -2;
        }
    }
}
