using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuel, double fuelConsumption)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
        }

        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }

        public string Drive(double km)
        {
            if (FuelConsumption*km<Fuel)
            {
                Fuel -= FuelConsumption * km;
                return "Travell";
            }
            else
            {
                return "Insufficient fuel!";
            }
        }

        public virtual string Refuel(double literss)
        {
            this.Fuel += literss;
            return "Successful refuel!";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Fuel} liters";
        }
    }
}
