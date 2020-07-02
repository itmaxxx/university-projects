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
        private List<string> bannedWords;

        public MainForm()
        {
            InitializeComponent();

            bannedWords = GetBannedWords(openFileDialogBannedWords.FileName);

            buttonSelectFolder_Click(new object(), new EventArgs());

            foreach (var word in bannedWords)
            {
                textBoxBannedWords.Text += $"{word}\r\n";
            }
        }

        private List<string> GetBannedWords(string path)
        {
            var words = new List<string>();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    words.Add(sr.ReadLine());
                }
            }

            return words;
        }
        
        private List<string> GetFolderContent(string path)
        {
            List<string> list = new List<string>();

            foreach (var item in Directory.GetDirectories(path))
            {
                list.AddRange(GetFolderContent(item));
            }

            foreach (var item in Directory.GetFiles(path))
            {
                list.Add($"{item}");
            }

            return list;
        }

        private void CheckFile(string path)
        {
            textBoxCurrentFile.Text += $"\r\n{path}\r\n\r\n";

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    textBoxCurrentFile.Text += $"{sr.ReadLine().Contains(bannedWords[0])}";
                }
            }

            textBoxCurrentFile.Text += $"\r\n\r\n";
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            // Uncomment & set SelectedPath on form empty
            //folderSelectSourceFolder.ShowDialog();

            labelPathToSourceFolder.Text = folderSelectSourceFolder.SelectedPath;

            var files = GetFolderContent(folderSelectSourceFolder.SelectedPath);

            foreach (var file in files)
            {
                textBoxFileStructure.Text += $"{file}\r\n";

                // Start words finder
                CheckFile(file);
            }
        }
    }
}
