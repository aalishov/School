using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Vehicle2
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelCapacity, double fuelQuantity, double fuelConsumption)
        {
            FuelCapacity = fuelCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value > FuelCapacity) 
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }
                fuelQuantity = value;
            }
        }

        public double FuelCapacity { get; set; }

        public virtual double FuelConsumption { get; set; }

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
