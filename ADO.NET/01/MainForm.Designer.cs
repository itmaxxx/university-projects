
namespace ADONET
{
	partial class MainForm
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
			this.listView = new System.Windows.Forms.ListView();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView
			// 
			this.listView.BackColor = System.Drawing.SystemColors.Window;
			this.listView.GridLines = true;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(12, 56);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(585, 320);
			this.listView.TabIndex = 0;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// comboBox
			// 
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(12, 27);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(212, 23);
			this.comboBox.TabIndex = 1;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Выберите таблицу";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(609, 388);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.listView);
			this.Name = "MainForm";
			this.Text = "Home";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Label label1;
	}
}

