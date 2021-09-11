using System;
using System.Collections.Generic;
using System.Text;

namespace P04_NeedForSpeed
{
    public abstract class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => 3;
    }
}
