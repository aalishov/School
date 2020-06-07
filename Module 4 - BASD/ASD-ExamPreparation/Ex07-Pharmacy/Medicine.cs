using System;
using System.Collections.Generic;
using System.Text;

namespace Ex07_Pharmacy
{
    public class Medicine
    {
        private double price;

        public Medicine(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid price");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"Medicine: {this.Name} with price {this.Price:f2}";
        }
    }
}
