using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07_ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> products;

        public Person(string name, double monye)
        {
            Name = name;
            Money = monye;
            Products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be an empty string.");
                }
                name = value;
            }
        }
        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be a negative number.");
                }
                money = value;
            }
        }
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public string Buy(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.Products.Add(product);
                return $"{this.Name} bought {product.Name}";
            }
            return $"{this.Name} can't afford {product.Name}";
        }

        public override string ToString()
        {
            if (products.Any())
            {
                return $"{this.Name} - {string.Join(", ", this.Products)}";
            }
            return $"{this.Name} - Nothing bought";
        }
    }
}
