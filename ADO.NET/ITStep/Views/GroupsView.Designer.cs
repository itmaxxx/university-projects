
namespace ITStep.Views
{
	partial class GroupsView
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
			this.buttonAddGroup = new System.Windows.Forms.Button();
			this.listBoxGroups = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxGroupName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxGroup = new System.Windows.Forms.GroupBox();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.textBoxSelectedGroupName = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBoxGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonAddGroup
			// 
			this.buttonAddGroup.Location = new System.Drawing.Point(6, 62);
			this.buttonAddGroup.Name = "buttonAddGroup";
			this.buttonAddGroup.Size = new System.Drawing.Size(252, 23);
			this.buttonAddGroup.TabIndex = 1;
			this.buttonAddGroup.Text = "Add group";
			this.buttonAddGroup.UseVisualStyleBackColor = true;
			this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
			// 
			// listBoxGroups
			// 
			this.listBoxGroups.FormattingEnabled = true;
			this.listBoxGroups.Location = new System.Drawing.Point(6, 19);
			this.listBoxGroups.Name = "listBoxGroups";
			this.listBoxGroups.Size = new System.Drawing.Size(297, 394);
			this.listBoxGroups.TabIndex = 0;
			this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
			this.listBoxGroups.DoubleClick += new System.EventHandler(this.listBoxGroups_DoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBoxGroups);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(309, 426);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Groups";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxGroupName);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.buttonAddGroup);
			this.groupBox2.Location = new System.Drawing.Point(327, 344);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 94);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add group";
			// 
			// textBoxGroupName
			// 
			this.textBoxGroupName.Location = new System.Drawing.Point(6, 36);
			this.textBoxGroupName.Name = "textBoxGroupName";
			this.textBoxGroupName.Size = new System.Drawing.Size(252, 20);
			this.textBoxGroupName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Group name";
			// 
			// groupBoxGroup
			// 
			this.groupBoxGroup.Controls.Add(this.buttonUpdate);
			this.groupBoxGroup.Controls.Add(this.textBoxSelectedGroupName);
			this.groupBoxGroup.Location = new System.Drawing.Point(327, 12);
			this.groupBoxGroup.Name = "groupBoxGroup";
			this.groupBoxGroup.Size = new System.Drawing.Size(264, 78);
			this.groupBoxGroup.TabIndex = 4;
			this.groupBoxGroup.TabStop = false;
			this.groupBoxGroup.Text = "Group";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(6, 45);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(252, 23);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "Update group";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// textBoxSelectedGroupName
			// 
			this.textBoxSelectedGroupName.Location = new System.Drawing.Point(6, 19);
			this.textBoxSelectedGroupName.Name = "textBoxSelectedGroupName";
			this.textBoxSelectedGroupName.Size = new System.Drawing.Size(252, 20);
			this.textBoxSelectedGroupName.TabIndex = 0;
			// 
			// GroupsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 450);
			this.Controls.Add(this.groupBoxGroup);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "GroupsView";
			this.Text = "Groups";
			this.Load += new System.EventHandler(this.GroupsView_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBoxGroup.ResumeLayout(false);
			this.groupBoxGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddGroup;
		private System.Windows.Forms.ListBox listBoxGroups;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxGroupName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxGroup;
		private System.Windows.Forms.TextBox textBoxSelectedGroupName;
		private System.Windows.Forms.Button buttonUpdate;
	}
}