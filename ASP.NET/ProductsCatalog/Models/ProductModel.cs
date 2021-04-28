using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsCatalog.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Image { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(int id, string image, string name, double price)
        {
            Id = id;
            Image = image;
            Name = name;
            Price = price;
        }
    }

    public class Products
    {
        public List<Product> ProductsList;

        public Products()
        {
            ProductsList = new List<Product>()
            {
                new Product(1, "iphone11_128gb_black.jpeg", "Iphone 11 128gb Black", 920),
                new Product(2, "iphone11_128gb_white.jpeg", "Iphone 11 128gb White", 940),
                new Product(3, "iphone11_128gb_green.jpeg", "Iphone 11 128gb Green", 900),
                new Product(4, "iphone11_128gb_purple.jpeg", "Iphone 11 128gb Purple", 900),
                new Product(5, "iphone11_128gb_black.jpeg", "Iphone 11 128gb Black", 920),
                new Product(6, "iphone11_128gb_white.jpeg", "Iphone 11 128gb White", 940),
                new Product(7, "iphone11_128gb_green.jpeg", "Iphone 11 128gb Green", 900),
                new Product(8, "iphone11_128gb_purple.jpeg", "Iphone 11 128gb Purple", 900)
            };
        }
    }
}
