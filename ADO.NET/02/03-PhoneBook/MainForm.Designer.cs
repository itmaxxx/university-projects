
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.sortByNameButton = new System.Windows.Forms.Button();
            this.sortByPhone = new System.Windows.Forms.Button();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.createContactButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addSaveButton = new System.Windows.Forms.Button();
            this.contactsGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsGroup
            // 
            this.contactsGroup.Controls.Add(this.createContactButton);
            this.contactsGroup.Controls.Add(this.deleteContactButton);
            this.contactsGroup.Controls.Add(this.sortByPhone);
            this.contactsGroup.Controls.Add(this.sortByNameButton);
            this.contactsGroup.Controls.Add(this.contactsListBox);
            this.contactsGroup.Location = new System.Drawing.Point(12, 12);
            this.contactsGroup.Name = "contactsGroup";
            this.contactsGroup.Size = new System.Drawing.Size(500, 655);
            this.contactsGroup.TabIndex = 0;
            this.contactsGroup.TabStop = false;
            this.contactsGroup.Text = "Contacts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addSaveButton);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(519, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact";
            // 
            // contactsListBox
            // 
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.ItemHeight = 25;
            this.contactsListBox.Location = new System.Drawing.Point(7, 79);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(487, 529);
            this.contactsListBox.TabIndex = 0;
            // 
            // sortByNameButton
            // 
            this.sortByNameButton.Location = new System.Drawing.Point(7, 39);
            this.sortByNameButton.Name = "sortByNameButton";
            this.sortByNameButton.Size = new System.Drawing.Size(244, 34);
            this.sortByNameButton.TabIndex = 1;
            this.sortByNameButton.Text = "Sort by name";
            this.sortByNameButton.UseVisualStyleBackColor = true;
            // 
            // sortByPhone
            // 
            this.sortByPhone.Location = new System.Drawing.Point(257, 39);
            this.sortByPhone.Name = "sortByPhone";
            this.sortByPhone.Size = new System.Drawing.Size(237, 34);
            this.sortByPhone.TabIndex = 2;
            this.sortByPhone.Text = "Sort by phone";
            this.sortByPhone.UseVisualStyleBackColor = true;
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Location = new System.Drawing.Point(7, 615);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(244, 34);
            this.deleteContactButton.TabIndex = 3;
            this.deleteContactButton.Text = "Delete contact";
            this.deleteContactButton.UseVisualStyleBackColor = true;
            // 
            // createContactButton
            // 
            this.createContactButton.Location = new System.Drawing.Point(257, 615);
            this.createContactButton.Name = "createContactButton";
            this.createContactButton.Size = new System.Drawing.Size(237, 34);
            this.createContactButton.TabIndex = 4;
            this.createContactButton.Text = "Create new contact";
            this.createContactButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Full name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(476, 31);
            this.nameTextBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 31);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 71);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phone number";
            // 
            // addSaveButton
            // 
            this.addSaveButton.Location = new System.Drawing.Point(6, 193);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(488, 34);
            this.addSaveButton.TabIndex = 2;
            this.addSaveButton.Text = "Save";
            this.addSaveButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.contactsGroup);
            this.Name = "MainForm";
            this.Text = "Phone Book";
            this.contactsGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contactsGroup;
        private System.Windows.Forms.Button createContactButton;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.Button sortByPhone;
        private System.Windows.Forms.Button sortByNameButton;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

