using _03_PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PhoneBook.Presenters
{
    public class ContactsPresenter
    {
        public List<Contact> Contacts { get; set; }

        private string path = Environment.CurrentDirectory + "//contacts.json";

        public ContactsPresenter()
        {
            Contacts = new List<Contact>();

            Load();
        }

        public async void Save()
        {
            try
            {
                //var json = JsonSerializer.Serialize(Contacts);

                //File.WriteAllText(path, json);

                using (var fs = new FileStream(path, FileMode.Create))
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
                var data = File.ReadAllText(path);
                var parsed = JsonSerializer.Deserialize<List<Contact>>(data);

                Contacts = parsed;
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

        public void SortByPhone()
        {
            Contacts = Contacts.OrderBy(c => c.Phone).ToList();
        }
    }
}
