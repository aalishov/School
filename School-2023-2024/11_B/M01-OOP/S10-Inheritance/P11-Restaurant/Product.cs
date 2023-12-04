using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Restaurant
{
    public class Product
    {
        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}
