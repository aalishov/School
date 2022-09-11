using System;
using System.Collections.Generic;
using System.Text;
namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(double fuel, int horsePower) : base(fuel, horsePower)
        {
        }
        public override double FuelConsumption
        {
            get => 8;
            set => base.FuelConsumption = value;
        }
    }

}