using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption= 10;
        }

        public Car(string make, string model, int year):this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public string Make
        {
            get { return make; }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set
            {
                fuelConsumption = value;
            }
        }

        public string Drive(double distance)
        {
             double fuelNeeded = distance * fuelConsumption;
            if (fuelNeeded<=FuelQuantity)
            {
                
                FuelQuantity -= fuelNeeded;
                return $"Car travelled: {distance}";
            }

            else { return "Not enough fuel to perform this trip!"; }

        }

        public string WhoAmI ()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
        }
    }
}
