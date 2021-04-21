
namespace _02_XML
{
    partial class MainWindow
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
            this.gemsColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gemsView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transparent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gemsView)).BeginInit();
            this.SuspendLayout();
            // 
            // gemsColor
            // 
            this.gemsColor.FormattingEnabled = true;
            this.gemsColor.Location = new System.Drawing.Point(12, 39);
            this.gemsColor.Name = "gemsColor";
            this.gemsColor.Size = new System.Drawing.Size(182, 33);
            this.gemsColor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select gem color";
            // 
            // gemsView
            // 
            this.gemsView.AllowUserToAddRows = false;
            this.gemsView.AllowUserToDeleteRows = false;
            this.gemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gemsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.color,
            this.transparent,
            this.quality});
            this.gemsView.Location = new System.Drawing.Point(12, 78);
            this.gemsView.Name = "gemsView";
            this.gemsView.ReadOnly = true;
            this.gemsView.RowHeadersWidth = 62;
            this.gemsView.RowTemplate.Height = 33;
            this.gemsView.Size = new System.Drawing.Size(776, 360);
            this.gemsView.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.MinimumWidth = 8;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 150;
            // 
            // transparent
            // 
            this.transparent.HeaderText = "Transparent";
            this.transparent.MinimumWidth = 8;
            this.transparent.Name = "transparent";
            this.transparent.ReadOnly = true;
            this.transparent.Width = 150;
            // 
            // quality
            // 
            this.quality.HeaderText = "Quality";
            this.quality.MinimumWidth = 8;
            this.quality.Name = "quality";
            this.quality.ReadOnly = true;
            this.quality.Width = 150;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gemsView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gemsColor);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.gemsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gemsColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gemsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn transparent;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality;
    }
}