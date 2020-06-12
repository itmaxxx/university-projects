namespace FileOpen
{
    partial class FileLauncher
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
            this.openFileDialogExe = new System.Windows.Forms.OpenFileDialog();
            this.buttonExe = new System.Windows.Forms.Button();
            this.openFileDialogTxt = new System.Windows.Forms.OpenFileDialog();
            this.buttonTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialogExe
            // 
            this.openFileDialogExe.Filter = "EXE files|*.exe";
            this.openFileDialogExe.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogExe_FileOk);
            // 
            // buttonExe
            // 
            this.buttonExe.Location = new System.Drawing.Point(12, 12);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(158, 23);
            this.buttonExe.TabIndex = 0;
            this.buttonExe.Text = "Open and start exe";
            this.buttonExe.UseVisualStyleBackColor = true;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // openFileDialogTxt
            // 
            this.openFileDialogTxt.Filter = "TXT files|*.txt";
            this.openFileDialogTxt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogTxt_FileOk);
            // 
            // buttonTxt
            // 
            this.buttonTxt.Location = new System.Drawing.Point(12, 41);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(158, 23);
            this.buttonTxt.TabIndex = 1;
            this.buttonTxt.Text = "Open and edit txt";
            this.buttonTxt.UseVisualStyleBackColor = true;
            this.buttonTxt.Click += new System.EventHandler(this.buttonTxt_Click);
            // 
            // FileLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 77);
            this.Controls.Add(this.buttonTxt);
            this.Controls.Add(this.buttonExe);
            this.Name = "FileLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogExe;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.OpenFileDialog openFileDialogTxt;
        private System.Windows.Forms.Button buttonTxt;
    }
}

