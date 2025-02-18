using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CarManufacturer
{
    public class Car
    {
        //Fields
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private List<Tire> tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Year = DateTime.Now.Year;
        }

        public Car(string make, string model, int year) : this()
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

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, List<Tire> tires): this(make,  model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }


        //Properties
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 2000) { throw new ArgumentException($"Invalid {nameof(Year)}"); }
                year = value;
            }
        }


        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }


        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public List <Tire> Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        //Methods
        public void Drive(double distance)
        {
            double razlika = fuelQuantity - (distance * fuelConsumption);
            if (razlika > 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L\nFuel consumption: {this.FuelConsumption:F2}L";
        }

    }
}
