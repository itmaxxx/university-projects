namespace CSC.Client
{
	partial class LoginForm
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
			this.buttonLogin = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.labelIP = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(12, 161);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(175, 48);
			this.buttonLogin.TabIndex = 0;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 9);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(74, 25);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Name:";
			// 
			// labelIP
			// 
			this.labelIP.AutoSize = true;
			this.labelIP.Location = new System.Drawing.Point(12, 83);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(106, 25);
			this.labelIP.TabIndex = 2;
			this.labelIP.Text = "Server IP:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(12, 37);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(365, 31);
			this.textBoxName.TabIndex = 3;
			this.textBoxName.Text = "Max";
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
			// 
			// textBoxIP
			// 
			this.textBoxIP.Location = new System.Drawing.Point(12, 111);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(365, 31);
			this.textBoxIP.TabIndex = 4;
			this.textBoxIP.Text = "127.0.0.1";
			this.textBoxIP.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(193, 161);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(184, 48);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 221);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.textBoxIP);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelIP);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonLogin);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Form";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxIP;
		private System.Windows.Forms.Button buttonCancel;
	}
}

