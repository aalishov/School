using System;
using System.Collections.Generic;
using System.Text;

namespace P10_NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            FuelConsumption = 1.25;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double kilometers)
        {
            double neededFuel = kilometers * FuelConsumption;
            if (neededFuel<=Fuel)
            {
                this.Fuel -= neededFuel;
            }
        }
    }
}
