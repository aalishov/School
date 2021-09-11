using System;
using System.Collections.Generic;
using System.Text;

namespace P04_NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => 8;
    }
}
