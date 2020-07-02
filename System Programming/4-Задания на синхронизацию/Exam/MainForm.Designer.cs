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
            this.labelPathToSourceFolder = new System.Windows.Forms.Label();
            this.folderSelectSourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFileStructure = new System.Windows.Forms.TextBox();
            this.textBoxBannedWords = new System.Windows.Forms.TextBox();
            this.openFileDialogBannedWords = new System.Windows.Forms.OpenFileDialog();
            this.textBoxCurrentFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSelectSourceFolder
            // 
            this.buttonSelectSourceFolder.Location = new System.Drawing.Point(12, 25);
            this.buttonSelectSourceFolder.Name = "buttonSelectSourceFolder";
            this.buttonSelectSourceFolder.Size = new System.Drawing.Size(147, 23);
            this.buttonSelectSourceFolder.TabIndex = 0;
            this.buttonSelectSourceFolder.Text = "buttonSelectSourceFolder";
            this.buttonSelectSourceFolder.UseVisualStyleBackColor = true;
            this.buttonSelectSourceFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // labelPathToSourceFolder
            // 
            this.labelPathToSourceFolder.AutoSize = true;
            this.labelPathToSourceFolder.Location = new System.Drawing.Point(12, 9);
            this.labelPathToSourceFolder.Name = "labelPathToSourceFolder";
            this.labelPathToSourceFolder.Size = new System.Drawing.Size(127, 13);
            this.labelPathToSourceFolder.TabIndex = 1;
            this.labelPathToSourceFolder.Text = "labelPathToSourceFolder";
            // 
            // folderSelectSourceFolder
            // 
            this.folderSelectSourceFolder.SelectedPath = "C:\\Users\\dmitr\\Desktop\\Мой репозиторий\\master\\System Programming\\4-Задания на син" +
    "хронизацию\\Exam";
            // 
            // textBoxFileStructure
            // 
            this.textBoxFileStructure.Location = new System.Drawing.Point(12, 54);
            this.textBoxFileStructure.Multiline = true;
            this.textBoxFileStructure.Name = "textBoxFileStructure";
            this.textBoxFileStructure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFileStructure.Size = new System.Drawing.Size(776, 199);
            this.textBoxFileStructure.TabIndex = 2;
            // 
            // textBoxBannedWords
            // 
            this.textBoxBannedWords.Location = new System.Drawing.Point(12, 259);
            this.textBoxBannedWords.Multiline = true;
            this.textBoxBannedWords.Name = "textBoxBannedWords";
            this.textBoxBannedWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBannedWords.Size = new System.Drawing.Size(241, 212);
            this.textBoxBannedWords.TabIndex = 3;
            // 
            // openFileDialogBannedWords
            // 
            this.openFileDialogBannedWords.FileName = "C:\\Users\\dmitr\\Desktop\\Мой репозиторий\\master\\System Programming\\4-Задания на син" +
    "хронизацию\\Exam\\bannedwords.txt";
            // 
            // textBoxCurrentFile
            // 
            this.textBoxCurrentFile.Location = new System.Drawing.Point(259, 259);
            this.textBoxCurrentFile.Multiline = true;
            this.textBoxCurrentFile.Name = "textBoxCurrentFile";
            this.textBoxCurrentFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCurrentFile.Size = new System.Drawing.Size(529, 212);
            this.textBoxCurrentFile.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.textBoxCurrentFile);
            this.Controls.Add(this.textBoxBannedWords);
            this.Controls.Add(this.textBoxFileStructure);
            this.Controls.Add(this.labelPathToSourceFolder);
            this.Controls.Add(this.buttonSelectSourceFolder);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectSourceFolder;
        private System.Windows.Forms.Label labelPathToSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog folderSelectSourceFolder;
        private System.Windows.Forms.TextBox textBoxFileStructure;
        private System.Windows.Forms.TextBox textBoxBannedWords;
        private System.Windows.Forms.OpenFileDialog openFileDialogBannedWords;
        private System.Windows.Forms.TextBox textBoxCurrentFile;
    }
}

