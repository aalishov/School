using System;
using System.Collections.Generic;
using System.Text;

namespace P04_VehicleLibrary
{
    public class Truck : Vehicle
    {
        const double SummerConsumption = 0.9;
        public Truck(string brand, string model, double fuelConsumption, double fuel) : base(brand, model, fuelConsumption+ SummerConsumption, fuel)
        {
        }

        public override string Refuel(double fuel)
        {
            double correctionFuel = fuel * 0.95;

            return base.Refuel(correctionFuel);
        }
    }
}
