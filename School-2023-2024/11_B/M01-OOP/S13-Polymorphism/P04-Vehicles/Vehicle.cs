using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            private set
            {
                if (fuelQuantity + value > TankCapacity)
                {
                    throw new ArgumentException($"Cannot fit {value} fuel in the tank");
                }
                fuelQuantity = value;
            }
        }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public string Drive(double distance)
        {
            double needed = distance * FuelConsumption;
            if (FuelQuantity >= needed)
            {
                FuelQuantity -= needed;
                return $"{this.GetType().Name} traveled {distance} km!";
            }
            return $"Insufficient fuel, please refuel!";
        }

        public virtual string Refuel(double amount)
        {
            FuelQuantity += amount;
            return $"{GetType().Name} fuel quantity: {FuelQuantity}";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}:");
            sb.AppendLine($"\tFuel consumption: {FuelConsumption}");
            sb.AppendLine($"\tFuel quantity: {FuelQuantity}");
            return sb.ToString().TrimEnd();
        }
    }
}
