using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            buttonSelectFolder_Click(new object(), new EventArgs());
        }
        
        private List<string> GetFolderContent(string path, string level = "")
        {
            List<string> list = new List<string>();

            foreach (var item in Directory.GetDirectories(path))
            {
                list.Add($"{level}D {item}");

                list.AddRange(GetFolderContent(item, level + "  "));
            }

            foreach (var item in Directory.GetFiles(path))
            {
                list.Add($"{level} F {item}");
            }

            return list;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            //folderSelectSourceFolder.ShowDialog();

            labelPathToSourceFolder.Text = folderSelectSourceFolder.SelectedPath;

            var content = GetFolderContent(folderSelectSourceFolder.SelectedPath);

            foreach (var item in content)
            {
                textBoxFileStructure.Text += $"{item}\r\n";
            }
        }
    }
}
