namespace Semaphore
{
    partial class SemaphoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
			this.listBoxWorking = new System.Windows.Forms.ListBox();
			this.listBoxWaiting = new System.Windows.Forms.ListBox();
			this.listBoxCreated = new System.Windows.Forms.ListBox();
			this.labelWorking = new System.Windows.Forms.Label();
			this.labelWaiting = new System.Windows.Forms.Label();
			this.labelCreated = new System.Windows.Forms.Label();
			this.buttonCreateThread = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxWorking
			// 
			this.listBoxWorking.FormattingEnabled = true;
			this.listBoxWorking.ItemHeight = 29;
			this.listBoxWorking.Location = new System.Drawing.Point(14, 51);
			this.listBoxWorking.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.listBoxWorking.Name = "listBoxWorking";
			this.listBoxWorking.Size = new System.Drawing.Size(275, 207);
			this.listBoxWorking.TabIndex = 0;
			this.listBoxWorking.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWorking_MouseDoubleClick);
			// 
			// listBoxWaiting
			// 
			this.listBoxWaiting.FormattingEnabled = true;
			this.listBoxWaiting.ItemHeight = 29;
			this.listBoxWaiting.Location = new System.Drawing.Point(303, 51);
			this.listBoxWaiting.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.listBoxWaiting.Name = "listBoxWaiting";
			this.listBoxWaiting.Size = new System.Drawing.Size(275, 207);
			this.listBoxWaiting.TabIndex = 0;
			// 
			// listBoxCreated
			// 
			this.listBoxCreated.FormattingEnabled = true;
			this.listBoxCreated.ItemHeight = 29;
			this.listBoxCreated.Location = new System.Drawing.Point(592, 51);
			this.listBoxCreated.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.listBoxCreated.Name = "listBoxCreated";
			this.listBoxCreated.Size = new System.Drawing.Size(275, 207);
			this.listBoxCreated.TabIndex = 0;
			this.listBoxCreated.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCreated_MouseDoubleClick);
			// 
			// labelWorking
			// 
			this.labelWorking.AutoSize = true;
			this.labelWorking.Location = new System.Drawing.Point(16, 9);
			this.labelWorking.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.labelWorking.Name = "labelWorking";
			this.labelWorking.Size = new System.Drawing.Size(102, 29);
			this.labelWorking.TabIndex = 1;
			this.labelWorking.Text = "Working";
			// 
			// labelWaiting
			// 
			this.labelWaiting.AutoSize = true;
			this.labelWaiting.Location = new System.Drawing.Point(296, 9);
			this.labelWaiting.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.labelWaiting.Name = "labelWaiting";
			this.labelWaiting.Size = new System.Drawing.Size(100, 29);
			this.labelWaiting.TabIndex = 1;
			this.labelWaiting.Text = "Queued";
			// 
			// labelCreated
			// 
			this.labelCreated.AutoSize = true;
			this.labelCreated.Location = new System.Drawing.Point(585, 9);
			this.labelCreated.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.labelCreated.Name = "labelCreated";
			this.labelCreated.Size = new System.Drawing.Size(99, 29);
			this.labelCreated.TabIndex = 1;
			this.labelCreated.Text = "Created";
			// 
			// buttonCreateThread
			// 
			this.buttonCreateThread.Location = new System.Drawing.Point(14, 272);
			this.buttonCreateThread.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.buttonCreateThread.Name = "buttonCreateThread";
			this.buttonCreateThread.Size = new System.Drawing.Size(853, 51);
			this.buttonCreateThread.TabIndex = 3;
			this.buttonCreateThread.Text = "Create thread";
			this.buttonCreateThread.UseVisualStyleBackColor = true;
			this.buttonCreateThread.Click += new System.EventHandler(this.buttonCreateThread_Click);
			// 
			// SemaphoreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 342);
			this.Controls.Add(this.buttonCreateThread);
			this.Controls.Add(this.labelCreated);
			this.Controls.Add(this.labelWaiting);
			this.Controls.Add(this.labelWorking);
			this.Controls.Add(this.listBoxCreated);
			this.Controls.Add(this.listBoxWaiting);
			this.Controls.Add(this.listBoxWorking);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.MaximizeBox = false;
			this.Name = "SemaphoreForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Semaphore";
			this.ResumeLayout(false);
			this.PerformLayout();
=======
            this.listBoxWorking = new System.Windows.Forms.ListBox();
            this.listBoxWaiting = new System.Windows.Forms.ListBox();
            this.listBoxCreated = new System.Windows.Forms.ListBox();
            this.labelWorking = new System.Windows.Forms.Label();
            this.labelWaiting = new System.Windows.Forms.Label();
            this.labelCreated = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonCreateThread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWorking
            // 
            this.listBoxWorking.FormattingEnabled = true;
            this.listBoxWorking.Location = new System.Drawing.Point(11, 28);
            this.listBoxWorking.Name = "listBoxWorking";
            this.listBoxWorking.Size = new System.Drawing.Size(120, 95);
            this.listBoxWorking.TabIndex = 0;
            this.listBoxWorking.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWorking_MouseDoubleClick);
            // 
            // listBoxWaiting
            // 
            this.listBoxWaiting.FormattingEnabled = true;
            this.listBoxWaiting.Location = new System.Drawing.Point(137, 28);
            this.listBoxWaiting.Name = "listBoxWaiting";
            this.listBoxWaiting.Size = new System.Drawing.Size(120, 95);
            this.listBoxWaiting.TabIndex = 0;
            // 
            // listBoxCreated
            // 
            this.listBoxCreated.FormattingEnabled = true;
            this.listBoxCreated.Location = new System.Drawing.Point(263, 28);
            this.listBoxCreated.Name = "listBoxCreated";
            this.listBoxCreated.Size = new System.Drawing.Size(120, 95);
            this.listBoxCreated.TabIndex = 0;
            this.listBoxCreated.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCreated_MouseDoubleClick);
            // 
            // labelWorking
            // 
            this.labelWorking.AutoSize = true;
            this.labelWorking.Location = new System.Drawing.Point(12, 9);
            this.labelWorking.Name = "labelWorking";
            this.labelWorking.Size = new System.Drawing.Size(75, 13);
            this.labelWorking.TabIndex = 1;
            this.labelWorking.Text = "Работающие:";
            // 
            // labelWaiting
            // 
            this.labelWaiting.AutoSize = true;
            this.labelWaiting.Location = new System.Drawing.Point(134, 9);
            this.labelWaiting.Name = "labelWaiting";
            this.labelWaiting.Size = new System.Drawing.Size(73, 13);
            this.labelWaiting.TabIndex = 1;
            this.labelWaiting.Text = "Ожидающие:";
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Location = new System.Drawing.Point(260, 9);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(67, 13);
            this.labelCreated.TabIndex = 1;
            this.labelCreated.Text = "Созданные:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 140);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(11, 124);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(97, 13);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Количество мест:";
            // 
            // buttonCreateThread
            // 
            this.buttonCreateThread.Location = new System.Drawing.Point(263, 137);
            this.buttonCreateThread.Name = "buttonCreateThread";
            this.buttonCreateThread.Size = new System.Drawing.Size(120, 23);
            this.buttonCreateThread.TabIndex = 3;
            this.buttonCreateThread.Text = "Создать поток";
            this.buttonCreateThread.UseVisualStyleBackColor = true;
            this.buttonCreateThread.Click += new System.EventHandler(this.buttonCreateThread_Click);
            // 
            // SemaphoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 170);
            this.Controls.Add(this.buttonCreateThread);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelCreated);
            this.Controls.Add(this.labelWaiting);
            this.Controls.Add(this.labelWorking);
            this.Controls.Add(this.listBoxCreated);
            this.Controls.Add(this.listBoxWaiting);
            this.Controls.Add(this.listBoxWorking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SemaphoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Семафоры";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> f97af47efb658675df04534720fd0da4c1b0bc42

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorking;
        private System.Windows.Forms.ListBox listBoxWaiting;
        private System.Windows.Forms.ListBox listBoxCreated;
        private System.Windows.Forms.Label labelWorking;
        private System.Windows.Forms.Label labelWaiting;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Button buttonCreateThread;
    }
}

