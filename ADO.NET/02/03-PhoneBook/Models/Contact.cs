using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _03_PhoneBook.Models
{
    public class Contact
    {
        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        public Contact()
        {
            Fullname = string.Empty;
            Phone = string.Empty;
        }
    }
}
