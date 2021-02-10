using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double fuelConsumption) : base(fuel, fuelConsumption)
        {
        }

        public override string Refuel(double literss)
        {
            this.Fuel += literss * 0.95;
            return "Successful refuel!";
        }
    }
}
