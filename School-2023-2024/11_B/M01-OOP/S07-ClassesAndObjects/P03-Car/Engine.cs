using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get { return horsePower; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid HorsePower!");
                }
                horsePower = value;
            }
        }
        public double CubicCapacity
        {
            get { return cubicCapacity; }
            set
            {
                cubicCapacity = value;
            }
        }
    }
}
