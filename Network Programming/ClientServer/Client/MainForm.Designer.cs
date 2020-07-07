namespace Client
{
	partial class MainForm
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
			this.textBoxChat = new System.Windows.Forms.TextBox();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.listBoxUsers = new System.Windows.Forms.ListBox();
			this.labelUsersList = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxChat
			// 
			this.textBoxChat.Location = new System.Drawing.Point(12, 12);
			this.textBoxChat.Multiline = true;
			this.textBoxChat.Name = "textBoxChat";
			this.textBoxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxChat.Size = new System.Drawing.Size(861, 761);
			this.textBoxChat.TabIndex = 0;
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Location = new System.Drawing.Point(12, 779);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(700, 31);
			this.textBoxMessage.TabIndex = 1;
			this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
			this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(718, 779);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(155, 40);
			this.buttonSend.TabIndex = 2;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// listBoxUsers
			// 
			this.listBoxUsers.FormattingEnabled = true;
			this.listBoxUsers.ItemHeight = 25;
			this.listBoxUsers.Location = new System.Drawing.Point(879, 43);
			this.listBoxUsers.Name = "listBoxUsers";
			this.listBoxUsers.Size = new System.Drawing.Size(301, 729);
			this.listBoxUsers.TabIndex = 3;
			this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
			this.listBoxUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxUsers_MouseDoubleClick);
			// 
			// labelUsersList
			// 
			this.labelUsersList.AutoSize = true;
			this.labelUsersList.Location = new System.Drawing.Point(879, 15);
			this.labelUsersList.Name = "labelUsersList";
			this.labelUsersList.Size = new System.Drawing.Size(232, 25);
			this.labelUsersList.TabIndex = 4;
			this.labelUsersList.Text = "Пользователи онлайн";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 828);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(961, 50);
			this.label1.TabIndex = 5;
			this.label1.Text = "Если выбран пользователь онлайн - ему будет отпрвлено личное сообщение\r\nЧтобы сбр" +
    "осить выбраного пользователя - двойной клик по лист боксу онлайн пользователей";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1204, 901);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelUsersList);
			this.Controls.Add(this.listBoxUsers);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.textBoxChat);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxChat;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.ListBox listBoxUsers;
		private System.Windows.Forms.Label labelUsersList;
		private System.Windows.Forms.Label label1;
	}
}