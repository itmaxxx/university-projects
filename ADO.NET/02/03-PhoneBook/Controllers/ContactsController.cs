using _03_PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PhoneBook.Controllers
{
    public class ContactsController
    {
        public List<Contact> Contacts { get; set; }

        private string path = Environment.CurrentDirectory + "//contacts.json";
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public ContactsController()
        {
            Contacts = new List<Contact>();
            Load();
        }

        public async void Save()
        {
            try
            {
                using (FileStream fs = new FileStream("contacts.json", FileMode.Create))
                {
                    await JsonSerializer.SerializeAsync(fs, Contacts);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Load()
        {
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream("contacts.json", FileMode.OpenOrCreate))
                {
                    // TODO: Read from file stream and write to contacts var
                    //Contacts = JsonSerializer.Deserialize<List<Contact>>();
                }
            }
        }

        public void Delete(Contact contact)
        {
            var result = Contacts.Remove(contact);
            MessageBox.Show(result.ToString());

        }

        public void SortByName()
        {
            Contacts = Contacts.OrderBy(c => c.Fullname).ToList();
        }

        public void SortByNumber()
        {
            Contacts = Contacts.OrderBy(c => c.Phone).ToList();
        }
    }
}
