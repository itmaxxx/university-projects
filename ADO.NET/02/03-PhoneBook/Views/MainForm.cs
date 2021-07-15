using _03_PhoneBook.Models;
using _03_PhoneBook.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PhoneBook
{
    enum SortBy { Fullname, Phone };

    public partial class MainForm : Form
    {
        private ContactsPresenter contactsPresenter;
        private SortBy sortBy;

        public MainForm()
        {
            InitializeComponent();
            sortBy = SortBy.Fullname;
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
            contactsPresenter = new ContactsPresenter();

            LoadContacts();
        }

        private void LoadContacts()
		{
            contactsListBox.DataSource = null;

			switch (sortBy)
			{
				case SortBy.Fullname:
                    contactsPresenter.SortByName();
					break;
				case SortBy.Phone:
                    contactsPresenter.SortByPhone();
                    break;
				default:
                    break;
			}

            contactsListBox.DataSource = contactsPresenter.Contacts;
            contactsListBox.DisplayMember = "Fullname";
		}

		private void addContactButton_Click(object sender, EventArgs e)
		{
            var newContact = new Contact { Fullname = nameTextBox.Text, Phone = phoneTextBox.Text };

            contactsPresenter.Contacts.Add(newContact);
            contactsPresenter.Save();

            nameTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;

            contactGroupBox.Visible = false;

            LoadContacts();

            MessageBox.Show("Contact added");
		}

		private void contactsListBox_Click(object sender, EventArgs e)
		{
            var listBox = sender as ListBox;

            try
            {
                contactGroupBox.Visible = true;

                contactNameTextBox.Text = contactsPresenter.Contacts[listBox.SelectedIndex].Fullname;
                contactPhoneTextBox.Text = contactsPresenter.Contacts[listBox.SelectedIndex].Phone;
            }
            catch (Exception ex)
            {
                contactGroupBox.Visible = false;

                MessageBox.Show(ex.Message);
            }
        }

		private void sortByNameButton_Click(object sender, EventArgs e)
		{
            sortBy = SortBy.Fullname;
            
            contactGroupBox.Visible = false;

            LoadContacts();
		}

		private void sortByPhone_Click(object sender, EventArgs e)
		{
            sortBy = SortBy.Phone;
            
            contactGroupBox.Visible = false;

            LoadContacts();
        }

		private void updateContactButton_Click(object sender, EventArgs e)
		{
            try
            {
                contactGroupBox.Visible = true;

                contactsPresenter.Contacts[contactsListBox.SelectedIndex].Fullname = contactNameTextBox.Text;
                contactsPresenter.Contacts[contactsListBox.SelectedIndex].Phone = contactPhoneTextBox.Text;
                contactsPresenter.Save();

                LoadContacts();

                MessageBox.Show("Contact updated");
            }
            catch (Exception ex)
            {
                contactGroupBox.Visible = false;

                MessageBox.Show(ex.Message);
            }
        }

		private void contactsListBox_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Delete)
			{
                try
				{
                    var deleteContact = MessageBox.Show(
                        "Are you sure you want to delete " + contactsPresenter.Contacts[contactsListBox.SelectedIndex].Fullname + "?",
                        "Confirm action",
                        MessageBoxButtons.YesNo
                        );

                    if (deleteContact == DialogResult.Yes)
					{
                        contactsPresenter.Contacts.RemoveAt(contactsListBox.SelectedIndex);
                        contactsPresenter.Save();

                        contactGroupBox.Visible = false;

                        LoadContacts();
                    }
                }
                catch (Exception ex)
				{
                    MessageBox.Show(ex.Message);
				}
            }
		}
	}
}
