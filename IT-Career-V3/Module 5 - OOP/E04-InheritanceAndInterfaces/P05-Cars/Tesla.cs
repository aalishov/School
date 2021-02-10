using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Cars
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla()
        {
            this.Battery = 100;
        }
        public int Battery { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" I'm electrical car! Battery: {this.Battery}%";
        }
    }
}
