using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_VendingMachine
{
    public class Drink
    {
        public Drink(string name, decimal price, int volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
        }

        public string Name { get; private set; }   
        public decimal Price { get; private set; }
        public int Volume { get; private set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: ${Price}, Volume: {Volume} ml";
        }
    }
}
