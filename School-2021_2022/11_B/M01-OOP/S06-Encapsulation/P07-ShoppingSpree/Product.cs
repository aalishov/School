using System;
using System.Collections.Generic;
using System.Text;

namespace P07_ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
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
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
