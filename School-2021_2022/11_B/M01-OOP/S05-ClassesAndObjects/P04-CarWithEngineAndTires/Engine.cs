using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        //Полета
        private int horsePower;
        private double cubicCapacity;

        //Конструктор
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        //Свойства
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
    }
}
