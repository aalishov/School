using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public virtual double FuelConsumption { get => DefaultFuelConsumption; }

        public virtual void Drive(double kilometers)
        {
            double neededFuel = kilometers * FuelConsumption;
            if (neededFuel <= Fuel)
            {
                Fuel -= neededFuel;
            }
        }

        public override string ToString()
        {
            return $"HP: {HorsePower} F: {Fuel} l";
        }
    }
}
