using System;
using System.Collections.Generic;
using System.Text;

namespace P05_CarManufacturer
{
    class Car
    {
        //Полета (Fields)
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private List<Tire> tires ;


        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.tires = new List<Tire>();
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, List<Tire> tires, Engine engine) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Tires = tires;
            this.Engine = engine;
        }

        //Свойства (Properties)
        public string Make
        {
            get { return this.make; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Make length must be more then 3 symbols");
                }
                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid car model");
                }
                this.model = value;
            }
        }

        public int Year
        {
            get { return this.year; }
            set
            {
                if (value < 1950 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Invalid car year");
                }
                this.year = value;
            }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public List<Tire> Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        //Методи
        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                return $"Travel {distance}, fuel quantity: {this.FuelQuantity}";
            }
            else
            {
                return "Not enough fuel to perform this trip!";
            }
        }
        
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }

        public override string ToString()
        {
            return $"Make: {this.Make}{Environment.NewLine} Model: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L\nEngine: {this.Engine}\nTires: {string.Join(", ",this.Tires)}";
        }
    }
}
