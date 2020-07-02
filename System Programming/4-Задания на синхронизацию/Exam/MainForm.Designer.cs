namespace Exam
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonSelectSourceFolder = new System.Windows.Forms.Button();
			this.folderSelectSourceFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.textBoxBannedWords = new System.Windows.Forms.TextBox();
			this.bannedWordsSelect = new System.Windows.Forms.OpenFileDialog();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.folderSelectDestination = new System.Windows.Forms.FolderBrowserDialog();
			this.buttonStart = new System.Windows.Forms.Button();
			this.textBoxPathToSourceFolder = new System.Windows.Forms.TextBox();
			this.textBoxPathToDestinationFolder = new System.Windows.Forms.TextBox();
			this.buttonSelectDestinationFolder = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.buttonSelectBannedWords = new System.Windows.Forms.Button();
			this.textBoxBannedWordsPath = new System.Windows.Forms.TextBox();
			this.labelBannedWordsList = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSelectSourceFolder
			// 
			this.buttonSelectSourceFolder.Location = new System.Drawing.Point(538, 25);
			this.buttonSelectSourceFolder.Margin = new System.Windows.Forms.Padding(6);
			this.buttonSelectSourceFolder.Name = "buttonSelectSourceFolder";
			this.buttonSelectSourceFolder.Size = new System.Drawing.Size(294, 44);
			this.buttonSelectSourceFolder.TabIndex = 0;
			this.buttonSelectSourceFolder.Text = "Source folder";
			this.buttonSelectSourceFolder.UseVisualStyleBackColor = true;
			this.buttonSelectSourceFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
			// 
			// textBoxBannedWords
			// 
			this.textBoxBannedWords.Location = new System.Drawing.Point(844, 68);
			this.textBoxBannedWords.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxBannedWords.Multiline = true;
			this.textBoxBannedWords.Name = "textBoxBannedWords";
			this.textBoxBannedWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxBannedWords.Size = new System.Drawing.Size(495, 130);
			this.textBoxBannedWords.TabIndex = 3;
			// 
			// bannedWordsSelect
			// 
			this.bannedWordsSelect.Filter = ".txt files|*.txt";
			// 
			// textBoxLog
			// 
			this.textBoxLog.Location = new System.Drawing.Point(15, 207);
			this.textBoxLog.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLog.Size = new System.Drawing.Size(1324, 553);
			this.textBoxLog.TabIndex = 4;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(524, 841);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(228, 44);
			this.buttonStart.TabIndex = 5;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// textBoxPathToSourceFolder
			// 
			this.textBoxPathToSourceFolder.Location = new System.Drawing.Point(15, 25);
			this.textBoxPathToSourceFolder.Name = "textBoxPathToSourceFolder";
			this.textBoxPathToSourceFolder.Size = new System.Drawing.Size(514, 31);
			this.textBoxPathToSourceFolder.TabIndex = 6;
			// 
			// textBoxPathToDestinationFolder
			// 
			this.textBoxPathToDestinationFolder.Location = new System.Drawing.Point(15, 92);
			this.textBoxPathToDestinationFolder.Name = "textBoxPathToDestinationFolder";
			this.textBoxPathToDestinationFolder.Size = new System.Drawing.Size(514, 31);
			this.textBoxPathToDestinationFolder.TabIndex = 7;
			// 
			// buttonSelectDestinationFolder
			// 
			this.buttonSelectDestinationFolder.Location = new System.Drawing.Point(538, 92);
			this.buttonSelectDestinationFolder.Name = "buttonSelectDestinationFolder";
			this.buttonSelectDestinationFolder.Size = new System.Drawing.Size(294, 44);
			this.buttonSelectDestinationFolder.TabIndex = 8;
			this.buttonSelectDestinationFolder.Text = "Destination folder";
			this.buttonSelectDestinationFolder.UseVisualStyleBackColor = true;
			this.buttonSelectDestinationFolder.Click += new System.EventHandler(this.buttonSelectDestinationFolder_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(15, 769);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(1324, 66);
			this.progressBar.TabIndex = 9;
			// 
			// buttonSelectBannedWords
			// 
			this.buttonSelectBannedWords.Location = new System.Drawing.Point(538, 154);
			this.buttonSelectBannedWords.Name = "buttonSelectBannedWords";
			this.buttonSelectBannedWords.Size = new System.Drawing.Size(294, 44);
			this.buttonSelectBannedWords.TabIndex = 11;
			this.buttonSelectBannedWords.Text = "Banned words file";
			this.buttonSelectBannedWords.UseVisualStyleBackColor = true;
			this.buttonSelectBannedWords.Click += new System.EventHandler(this.buttonSelectBannedWords_Click);
			// 
			// textBoxBannedWordsPath
			// 
			this.textBoxBannedWordsPath.Location = new System.Drawing.Point(15, 154);
			this.textBoxBannedWordsPath.Name = "textBoxBannedWordsPath";
			this.textBoxBannedWordsPath.Size = new System.Drawing.Size(514, 31);
			this.textBoxBannedWordsPath.TabIndex = 10;
			// 
			// labelBannedWordsList
			// 
			this.labelBannedWordsList.AutoSize = true;
			this.labelBannedWordsList.Location = new System.Drawing.Point(841, 31);
			this.labelBannedWordsList.Name = "labelBannedWordsList";
			this.labelBannedWordsList.Size = new System.Drawing.Size(188, 25);
			this.labelBannedWordsList.TabIndex = 12;
			this.labelBannedWordsList.Text = "Banned words list:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1357, 901);
			this.Controls.Add(this.labelBannedWordsList);
			this.Controls.Add(this.buttonSelectBannedWords);
			this.Controls.Add(this.textBoxBannedWordsPath);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.buttonSelectDestinationFolder);
			this.Controls.Add(this.textBoxPathToDestinationFolder);
			this.Controls.Add(this.textBoxPathToSourceFolder);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textBoxLog);
			this.Controls.Add(this.textBoxBannedWords);
			this.Controls.Add(this.buttonSelectSourceFolder);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exam";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog folderSelectSourceFolder;
        private System.Windows.Forms.TextBox textBoxBannedWords;
        private System.Windows.Forms.OpenFileDialog bannedWordsSelect;
        private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.FolderBrowserDialog folderSelectDestination;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.TextBox textBoxPathToSourceFolder;
		private System.Windows.Forms.TextBox textBoxPathToDestinationFolder;
		private System.Windows.Forms.Button buttonSelectDestinationFolder;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button buttonSelectBannedWords;
		private System.Windows.Forms.TextBox textBoxBannedWordsPath;
		private System.Windows.Forms.Label labelBannedWordsList;
	}
}

