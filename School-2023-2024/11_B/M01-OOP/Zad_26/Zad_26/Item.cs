using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_26
{
    public class Item
    {
        private string description;
        private double price;

        public Item(string description, double price)
        {
            Description = description;
            Price = price;
        }

        public string Description
        {
            get { return description; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Invalid {nameof(Description)}");
                }
                description = value;
            }
        }

        public double Price
        {
            get { return price; }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException($"Invalid {nameof(Price)}");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return $"{Description} ({Price:f2})";
        }
    }
}
