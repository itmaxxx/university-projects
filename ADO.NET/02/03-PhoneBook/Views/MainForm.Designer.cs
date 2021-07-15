
namespace _03_PhoneBook
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
			this.contactsGroup = new System.Windows.Forms.GroupBox();
			this.sortByPhone = new System.Windows.Forms.Button();
			this.sortByNameButton = new System.Windows.Forms.Button();
			this.contactsListBox = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.addContactButton = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.contactGroupBox = new System.Windows.Forms.GroupBox();
			this.updateContactButton = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.contactPhoneTextBox = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.contactNameTextBox = new System.Windows.Forms.TextBox();
			this.contactsGroup.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.contactGroupBox.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// contactsGroup
			// 
			this.contactsGroup.Controls.Add(this.sortByPhone);
			this.contactsGroup.Controls.Add(this.sortByNameButton);
			this.contactsGroup.Controls.Add(this.contactsListBox);
			this.contactsGroup.Location = new System.Drawing.Point(8, 7);
			this.contactsGroup.Margin = new System.Windows.Forms.Padding(2);
			this.contactsGroup.Name = "contactsGroup";
			this.contactsGroup.Padding = new System.Windows.Forms.Padding(2);
			this.contactsGroup.Size = new System.Drawing.Size(350, 393);
			this.contactsGroup.TabIndex = 0;
			this.contactsGroup.TabStop = false;
			this.contactsGroup.Text = "Contacts";
			// 
			// sortByPhone
			// 
			this.sortByPhone.Location = new System.Drawing.Point(180, 19);
			this.sortByPhone.Margin = new System.Windows.Forms.Padding(2);
			this.sortByPhone.Name = "sortByPhone";
			this.sortByPhone.Size = new System.Drawing.Size(166, 31);
			this.sortByPhone.TabIndex = 2;
			this.sortByPhone.Text = "Sort by phone";
			this.sortByPhone.UseVisualStyleBackColor = true;
			this.sortByPhone.Click += new System.EventHandler(this.sortByPhone_Click);
			// 
			// sortByNameButton
			// 
			this.sortByNameButton.Location = new System.Drawing.Point(5, 19);
			this.sortByNameButton.Margin = new System.Windows.Forms.Padding(2);
			this.sortByNameButton.Name = "sortByNameButton";
			this.sortByNameButton.Size = new System.Drawing.Size(171, 31);
			this.sortByNameButton.TabIndex = 1;
			this.sortByNameButton.Text = "Sort by name";
			this.sortByNameButton.UseVisualStyleBackColor = true;
			this.sortByNameButton.Click += new System.EventHandler(this.sortByNameButton_Click);
			// 
			// contactsListBox
			// 
			this.contactsListBox.FormattingEnabled = true;
			this.contactsListBox.ItemHeight = 15;
			this.contactsListBox.Location = new System.Drawing.Point(5, 53);
			this.contactsListBox.Margin = new System.Windows.Forms.Padding(2);
			this.contactsListBox.Name = "contactsListBox";
			this.contactsListBox.Size = new System.Drawing.Size(341, 334);
			this.contactsListBox.TabIndex = 0;
			this.contactsListBox.Click += new System.EventHandler(this.contactsListBox_Click);
			this.contactsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactsListBox_KeyDown);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.addContactButton);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Location = new System.Drawing.Point(362, 248);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(350, 152);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add contact";
			// 
			// addContactButton
			// 
			this.addContactButton.Location = new System.Drawing.Point(4, 116);
			this.addContactButton.Margin = new System.Windows.Forms.Padding(2);
			this.addContactButton.Name = "addContactButton";
			this.addContactButton.Size = new System.Drawing.Size(342, 31);
			this.addContactButton.TabIndex = 2;
			this.addContactButton.Text = "Create new contact";
			this.addContactButton.UseVisualStyleBackColor = true;
			this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.phoneTextBox);
			this.groupBox3.Location = new System.Drawing.Point(4, 70);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(342, 43);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Phone number";
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(4, 18);
			this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(334, 23);
			this.phoneTextBox.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nameTextBox);
			this.groupBox1.Location = new System.Drawing.Point(4, 23);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(342, 43);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Full name";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(4, 18);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(334, 23);
			this.nameTextBox.TabIndex = 0;
			// 
			// contactGroupBox
			// 
			this.contactGroupBox.Controls.Add(this.updateContactButton);
			this.contactGroupBox.Controls.Add(this.groupBox4);
			this.contactGroupBox.Controls.Add(this.groupBox5);
			this.contactGroupBox.Location = new System.Drawing.Point(363, 7);
			this.contactGroupBox.Name = "contactGroupBox";
			this.contactGroupBox.Size = new System.Drawing.Size(349, 152);
			this.contactGroupBox.TabIndex = 2;
			this.contactGroupBox.TabStop = false;
			this.contactGroupBox.Text = "Contact";
			this.contactGroupBox.Visible = false;
			// 
			// updateContactButton
			// 
			this.updateContactButton.Location = new System.Drawing.Point(7, 113);
			this.updateContactButton.Margin = new System.Windows.Forms.Padding(2);
			this.updateContactButton.Name = "updateContactButton";
			this.updateContactButton.Size = new System.Drawing.Size(338, 31);
			this.updateContactButton.TabIndex = 3;
			this.updateContactButton.Text = "Update contact";
			this.updateContactButton.UseVisualStyleBackColor = true;
			this.updateContactButton.Click += new System.EventHandler(this.updateContactButton_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.contactPhoneTextBox);
			this.groupBox4.Location = new System.Drawing.Point(7, 68);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(342, 43);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Phone number";
			// 
			// contactPhoneTextBox
			// 
			this.contactPhoneTextBox.Location = new System.Drawing.Point(4, 18);
			this.contactPhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.contactPhoneTextBox.Name = "contactPhoneTextBox";
			this.contactPhoneTextBox.Size = new System.Drawing.Size(334, 23);
			this.contactPhoneTextBox.TabIndex = 0;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.contactNameTextBox);
			this.groupBox5.Location = new System.Drawing.Point(7, 21);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox5.Size = new System.Drawing.Size(342, 43);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Full name";
			// 
			// contactNameTextBox
			// 
			this.contactNameTextBox.Location = new System.Drawing.Point(4, 18);
			this.contactNameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.contactNameTextBox.Name = "contactNameTextBox";
			this.contactNameTextBox.Size = new System.Drawing.Size(334, 23);
			this.contactNameTextBox.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 407);
			this.Controls.Add(this.contactGroupBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.contactsGroup);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Phone Book";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contactsGroup.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.contactGroupBox.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contactsGroup;
        private System.Windows.Forms.Button sortByPhone;
        private System.Windows.Forms.Button sortByNameButton;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.GroupBox contactGroupBox;
		private System.Windows.Forms.Button updateContactButton;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox contactPhoneTextBox;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox contactNameTextBox;
	}
}

