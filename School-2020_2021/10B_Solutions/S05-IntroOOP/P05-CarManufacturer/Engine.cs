using System;
using System.Collections.Generic;
using System.Text;

namespace P05_CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }
        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            set { this.cubicCapacity = value; }
        }

        public override string ToString()
        {
            return $"\n\tHorse power: {this.HorsePower}\n\tCubic capacity: {this.CubicCapacity}";
        }
    }
}
