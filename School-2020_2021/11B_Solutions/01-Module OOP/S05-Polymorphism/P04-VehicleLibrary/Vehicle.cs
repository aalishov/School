using System;

namespace P04_VehicleLibrary
{
    public abstract class Vehicle
    {
        private double fuelConsumption;

        private double fuel;
        private string brand;
        private string model;

        public Vehicle(string brand, string model, double fuelConsumption, double fuel)
        {
            this.Brand = brand;
            this.Model = model;
            this.FuelConsumption = fuelConsumption;
            this.Fuel = fuel;
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{this.GetType().Name} brand can't be null or emty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{this.GetType().Name} brand can't be less then 3 symbol!");
                }
                brand = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{this.GetType().Name} model can't be null or emty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{this.GetType().Name} model can't be less then 3 symbol!");
                }
                model = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{this.GetType().Name} fuel consumtion can't be zero or negative!");
                }
                this.fuelConsumption = value;
            }
        }

        public double Fuel
        {
            get { return this.fuel; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{this.GetType().Name} fuel can't be negative!");
                }
                this.fuel = value;
            }
        }

        public virtual string Refuel(double fuel)
        {
            if (fuel > 0)
            {
                this.Fuel += fuel;
                return $"Refuel: {fuel:f2}, {this.GetType().Name} {this.Brand} {this.Model} fuel: {this.Fuel:f2}";
            }
            else
            {
                return "Invalid fuel amount!";
            }
        }

        public string Drive(double km)
        {
            double needFuel = km * FuelConsumption;
            if (needFuel <= this.Fuel)
            {
                this.Fuel -= needFuel;
                return $"{this.GetType().Name} {this.Brand} {this.Model} travelled {km} km";
            }
            else
            {
                return $"{this.GetType().Name} {this.Brand} {this.Model} needs refueling";
            }
        }
    }
}
