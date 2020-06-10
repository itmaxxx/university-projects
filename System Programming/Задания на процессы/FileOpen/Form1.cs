using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOpen
{
    public partial class FileLauncher : Form
    {
        public FileLauncher()
        {
            InitializeComponent();
        }

        private void buttonExe_Click(object sender, EventArgs e)
        {
            openFileDialogExe.ShowDialog();
        }

        private void openFileDialogExe_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }

            Process.Start(openFileDialogExe.FileName);
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            openFileDialogTxt.ShowDialog();
        }

        private void openFileDialogTxt_FileOk(object sender, CancelEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }

            Process.Start("notepad.exe", openFileDialogTxt.FileName);
        }
    }
}
