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
            this.folderSelectSourceFolder.SelectedPath = "C:\\Users\\dmitr\\Desktop\\Семафоры";
            // 
            // textBoxFileStructure
            // 
            this.textBoxFileStructure.Location = new System.Drawing.Point(12, 54);
            this.textBoxFileStructure.Multiline = true;
            this.textBoxFileStructure.Name = "textBoxFileStructure";
            this.textBoxFileStructure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFileStructure.Size = new System.Drawing.Size(776, 344);
            this.textBoxFileStructure.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

