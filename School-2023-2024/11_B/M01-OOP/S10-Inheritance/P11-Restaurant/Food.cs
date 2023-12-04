using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Restaurant
{
    public class Food : Product
    {
        protected Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
        public double Grams { get; private set; }
    }
}
