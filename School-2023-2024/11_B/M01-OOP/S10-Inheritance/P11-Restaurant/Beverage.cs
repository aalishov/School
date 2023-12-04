using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Restaurant
{
    public class Beverage : Product
    {
        protected Beverage(string name, decimal price, double mililitres) : base(name, price)
        {
            Mililitres = mililitres;
        }
        public double Mililitres { get; private set; }
    }
}
