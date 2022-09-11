using System;
using System.Collections.Generic;
using System.Text;
namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(double fuel, int horsePower) : base(fuel, horsePower)
        {
        }
        public override double FuelConsumption
        {
            get => 10;
            set => base.FuelConsumption = value;
        }
    }
}
