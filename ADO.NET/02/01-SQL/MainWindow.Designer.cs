
namespace _01_SQL
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.workerSelector = new System.Windows.Forms.ComboBox();
            this.worker = new System.Windows.Forms.Label();
            this.WorkingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkingDays});
            this.dataGridView.Location = new System.Drawing.Point(12, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(366, 417);
            this.dataGridView.TabIndex = 0;
            // 
            // workerSelector
            // 
            this.workerSelector.FormattingEnabled = true;
            this.workerSelector.Location = new System.Drawing.Point(12, 37);
            this.workerSelector.Name = "workerSelector";
            this.workerSelector.Size = new System.Drawing.Size(366, 33);
            this.workerSelector.TabIndex = 1;
            this.workerSelector.SelectedIndexChanged += new System.EventHandler(this.workerSelector_SelectedIndexChanged);
            // 
            // worker
            // 
            this.worker.AutoSize = true;
            this.worker.Location = new System.Drawing.Point(12, 9);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(117, 25);
            this.worker.TabIndex = 2;
            this.worker.Text = "Select worker";
            // 
            // WorkingDays
            // 
            this.WorkingDays.HeaderText = "Working days";
            this.WorkingDays.MinimumWidth = 8;
            this.WorkingDays.Name = "WorkingDays";
            this.WorkingDays.ReadOnly = true;
            this.WorkingDays.Width = 300;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 505);
            this.Controls.Add(this.worker);
            this.Controls.Add(this.workerSelector);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainWindow";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingDays;
        private System.Windows.Forms.ComboBox workerSelector;
        private System.Windows.Forms.Label worker;
    }
}

