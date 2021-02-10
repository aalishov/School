using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05_P03_Product_Shop
{
    class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"  Product: {this.Name}, Price: {this.Price:f2}";
        }
    }
}
