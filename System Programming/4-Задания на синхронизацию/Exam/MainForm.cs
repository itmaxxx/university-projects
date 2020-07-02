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
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.InteropServices;

namespace Exam
{
    public partial class MainForm : Form
    {
        private List<string> bannedWords;
        private string bannedWordsPattern;
        private Regex bannedWordsRegex;

        private string sourceFolderPath;
        private string destinationFolderPath;
        private string bannedWordsPath;

        private Dictionary<string, int> globalDictionary;

        private Task[] tasks;

        private Semaphore semaphore = new Semaphore(5, 5);

        private string report = string.Empty;

        private object lockObj = new object();

        public MainForm()
        {
            InitializeComponent();

            globalDictionary = new Dictionary<string, int>();
        }

        private List<string> GetBannedWords(string path)
        {
            var words = new List<string>();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    words.Add(sr.ReadLine().ToLower());
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

            foreach (var item in Directory.GetFiles(path, "*.txt"))
            {
                list.Add($"{item}");
            }

            return list;
        }

        private void CheckFile(string path)
        {
            semaphore.WaitOne();

            var localDictionary = new Dictionary<string, int>();

            lock (lockObj)
			{
                report += $"\r\n{path}\r\n";

                using (var sr = new StreamReader(path))
                {
                    string fileText = sr.ReadToEnd().ToLower();

                    bool containsAtLeastOneWord = false;

                    foreach (var word in bannedWords)
                    {
                        if (fileText.Contains(word))
                        {
                            containsAtLeastOneWord = true;

                            break;
                        }
                    }

                    if (!containsAtLeastOneWord)
                    {
                        report += "nothing found\r\n";

                        return;
                    }

                    MatchCollection matches = bannedWordsRegex.Matches(fileText);

                    foreach (Match match in matches)
                    {
                        if (localDictionary.ContainsKey(match.Value))
                        {
                            localDictionary[match.Value]++;
                        }
                        else
                        {
                            localDictionary.Add(match.Value, 1);
                        }
                    }

                    foreach (var word in localDictionary)
                    {
                        fileText = fileText.Replace(word.Key, "*******");
                    }

                    Regex regex = new Regex(@"(:\\(.+)\\(.+).txt)");

                    var regexRes = regex.Match(path);

                    string fileName = regexRes.Groups[regexRes.Groups.Count - 1].Value;

					using (var sw = new StreamWriter(destinationFolderPath + $@"\{fileName}.txt"))
					{
                        sw.Write(fileText);
					}
                }

                foreach (var word in localDictionary.OrderByDescending(w => w.Value))
                {
                    report += $"{word.Key} - {word.Value}\r\n";
                }

                report += $"\r\n";
            }

            progressBar.BeginInvoke((MethodInvoker)(() => {
                progressBar.Value++;
            }));

            foreach (var word in localDictionary)
            {
                if (globalDictionary.ContainsKey(word.Key))
				{
                    globalDictionary[word.Key] += word.Value;
                }
                else
				{
                    globalDictionary.Add(word.Key, word.Value);
                }
            }

            // Last task finishes
            if (tasks.Where((t) => t.IsCompleted == false).ToArray().Length == 1)
			{
                report += $"Global banned words stats : \r\n";

                foreach (var word in globalDictionary.OrderByDescending(w => w.Value))
                {
                    report += $"{word.Key} - {word.Value}\r\n";
                }

				// Save report
				using (var sw = new StreamWriter(destinationFolderPath + @"\report.txt"))
				{
                    sw.Write(report);
				}

                textBoxLog.BeginInvoke((MethodInvoker)(() => {
                    textBoxLog.Text = report;
                }));
            }

            semaphore.Release();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
			folderSelectSourceFolder.ShowDialog();

			textBoxPathToSourceFolder.Text = folderSelectSourceFolder.SelectedPath;
        }

		private void buttonSelectDestinationFolder_Click(object sender, EventArgs e)
		{
			folderSelectDestination.ShowDialog();

			textBoxPathToDestinationFolder.Text = folderSelectDestination.SelectedPath;
        }

		private void buttonStart_Click(object sender, EventArgs e)
		{
            sourceFolderPath = textBoxPathToSourceFolder.Text.Length > 0 ? textBoxPathToSourceFolder.Text : folderSelectSourceFolder.SelectedPath;
            destinationFolderPath = textBoxPathToDestinationFolder.Text.Length > 0 ? textBoxPathToDestinationFolder.Text : folderSelectDestination.SelectedPath;
            bannedWordsPath = textBoxBannedWordsPath.Text.Length > 0 ? textBoxBannedWordsPath.Text : bannedWordsSelect.FileName;

            if (sourceFolderPath == string.Empty || destinationFolderPath == string.Empty || bannedWordsPath == string.Empty)
			{
                MessageBox.Show("You didn't selected all the paths!");

                return;
			}

            report += $"Source folder path : {sourceFolderPath}\r\n";
            report += $"Destination folder path : {destinationFolderPath}\r\n";
            report += $"Banned words file location : {bannedWordsPath}\r\n";

            textBoxBannedWordsPath.Text = bannedWordsSelect.FileName;

            bannedWords = GetBannedWords(bannedWordsSelect.FileName);

            bannedWordsPattern = "(";

            for (int i = 0; i < bannedWords.Count; i++)
            {
                var word = bannedWords[i];

                textBoxBannedWords.Text += $"{word}\r\n";

                bannedWordsPattern += $"{word}{(i == bannedWords.Count - 1 ? "" : "|")}";
            }

            bannedWordsPattern += ")";

            bannedWordsRegex = new Regex(bannedWordsPattern, RegexOptions.Multiline | RegexOptions.IgnoreCase);

            report += "\r\nBanned words : ";

            for (int i = 0; i < bannedWords.Count; i++)
            {
                var word = bannedWords[i];

                report += $"{word}{(i == bannedWords.Count - 1 ? "." : ", ")}";
            }

            report += "\r\n";

            var files = GetFolderContent(sourceFolderPath);

            progressBar.Maximum = files.Count;

            tasks = new Task[files.Count];

            for (int i = 0; i < files.Count; i++)
            {
                int current = i;

                // Start words banner
                var task = new Task(() => CheckFile(files[current]));

                tasks[i] = task;

                task.Start();
            }
        }

		private void buttonSelectBannedWords_Click(object sender, EventArgs e)
		{
			bannedWordsSelect.ShowDialog();

            textBoxBannedWordsPath.Text = bannedWordsSelect.FileName;
        }
	}
}