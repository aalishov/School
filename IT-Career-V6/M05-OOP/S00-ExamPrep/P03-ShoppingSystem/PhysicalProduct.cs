using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    public class PhysicalProduct : Product
    {
        private double weight;

        public PhysicalProduct(string name, double price, double weight) : base(name, price)
        {
            Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight cannot be less or equal to 0!");
                }
                weight = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Weight: {Weight}";
        }
    }
}
