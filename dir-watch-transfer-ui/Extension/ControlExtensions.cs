﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dir_watch_transfer_ui
{
    /// <summary>
    /// Source - https://stackoverflow.com/questions/4802744/adjust-listview-columns-to-fit-with-winforms
    /// </summary>
    public static class ControlExtensions
    {
        public static void DoubleBuffer(this Control control)
        {
            // http://stackoverflow.com/questions/76993/how-to-double-buffer-net-controls-on-a-form/77233#77233
            // Taxes: Remote Desktop Connection and painting: http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx

            if (System.Windows.Forms.SystemInformation.TerminalServerSession) return;
            System.Reflection.PropertyInfo dbProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            dbProp.SetValue(control, true, null);
        }
    }
}
