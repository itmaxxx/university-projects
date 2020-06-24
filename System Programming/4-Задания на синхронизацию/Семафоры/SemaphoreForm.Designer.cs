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
            this.listBoxWorking.Location = new System.Drawing.Point(12, 66);
            this.listBoxWorking.Name = "listBoxWorking";
            this.listBoxWorking.Size = new System.Drawing.Size(120, 95);
            this.listBoxWorking.TabIndex = 0;
            this.listBoxWorking.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWorking_MouseDoubleClick);
            // 
            // listBoxWaiting
            // 
            this.listBoxWaiting.FormattingEnabled = true;
            this.listBoxWaiting.Location = new System.Drawing.Point(222, 66);
            this.listBoxWaiting.Name = "listBoxWaiting";
            this.listBoxWaiting.Size = new System.Drawing.Size(120, 95);
            this.listBoxWaiting.TabIndex = 0;
            // 
            // listBoxCreated
            // 
            this.listBoxCreated.FormattingEnabled = true;
            this.listBoxCreated.Location = new System.Drawing.Point(440, 66);
            this.listBoxCreated.Name = "listBoxCreated";
            this.listBoxCreated.Size = new System.Drawing.Size(120, 95);
            this.listBoxCreated.TabIndex = 0;
            this.listBoxCreated.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCreated_MouseDoubleClick);
            // 
            // labelWorking
            // 
            this.labelWorking.AutoSize = true;
            this.labelWorking.Location = new System.Drawing.Point(13, 47);
            this.labelWorking.Name = "labelWorking";
            this.labelWorking.Size = new System.Drawing.Size(75, 13);
            this.labelWorking.TabIndex = 1;
            this.labelWorking.Text = "Работающие:";
            // 
            // labelWaiting
            // 
            this.labelWaiting.AutoSize = true;
            this.labelWaiting.Location = new System.Drawing.Point(219, 47);
            this.labelWaiting.Name = "labelWaiting";
            this.labelWaiting.Size = new System.Drawing.Size(73, 13);
            this.labelWaiting.TabIndex = 1;
            this.labelWaiting.Text = "Ожидающие:";
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Location = new System.Drawing.Point(437, 47);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(67, 13);
            this.labelCreated.TabIndex = 1;
            this.labelCreated.Text = "Созданные:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 201);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 185);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(97, 13);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Количество мест:";
            // 
            // buttonCreateThread
            // 
            this.buttonCreateThread.Location = new System.Drawing.Point(222, 198);
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
            this.ClientSize = new System.Drawing.Size(572, 233);
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

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorking;
        private System.Windows.Forms.ListBox listBoxWaiting;
        private System.Windows.Forms.ListBox listBoxCreated;
        private System.Windows.Forms.Label labelWorking;
        private System.Windows.Forms.Label labelWaiting;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonCreateThread;
    }
}

