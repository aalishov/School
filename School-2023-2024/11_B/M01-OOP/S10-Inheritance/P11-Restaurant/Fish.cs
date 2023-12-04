using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Restaurant
{
    public class Fish : MainDish
    {
        private static double Grams = 22;

        public Fish(string name, decimal price) : base(name, price, Grams)
        {
        }
    }
}
