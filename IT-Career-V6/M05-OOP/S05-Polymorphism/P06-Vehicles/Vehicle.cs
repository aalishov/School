using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public string Drive(int distance)
        {
            double neededFuel = distance * FuelConsumption;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }

        public virtual string Refuel(double fuelAmount)
        {
            FuelQuantity += fuelAmount;
            return $"{GetType().Name} refuel {fuelAmount} l, fuel quantity: {FuelQuantity} l";
        }

        public override string ToString()
        {
            return $"{GetType().Name} fuel: {FuelQuantity} l, fuel consumtpion: {FuelConsumption} l/100km";
        }
    }
}
