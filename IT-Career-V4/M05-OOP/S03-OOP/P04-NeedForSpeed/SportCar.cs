﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04_NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => 10;
    }
}
