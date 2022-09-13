using System;

namespace Vehicles
{
    public class Vehicle
    {
        private double fuelConsumtion;
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumtion, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumtion;
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            private set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            }
        }
        public virtual double FuelConsumption
        {
            get => fuelConsumtion;
            private set => fuelConsumtion = value;
        }
        public double TankCapacity { get; private set; }
        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel > this.FuelQuantity)
            {
                return $"{this.GetType().Name} needs refueling";
            }
            FuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }
        public virtual void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (quantity + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
            this.FuelQuantity += quantity;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
