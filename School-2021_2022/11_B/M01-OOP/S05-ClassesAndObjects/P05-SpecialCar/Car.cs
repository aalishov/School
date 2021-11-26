namespace CarManufacturer
{
    public class Car
    {
        //Полета
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        //Конструктори
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year):this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        //Свойства
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption/100;
            if (this.FuelQuantity-neededFuel>=0)
            {
                this.FuelQuantity -= neededFuel;
                return $"{this.Make} {this.Model} -> Traveled {distance}, current fuel: {this.FuelQuantity}";
            }
            else
            {
                return $"{this.Make} {this.Model} -> Not enough fuel to perform this trip!";
            }
        }
        public string Refuel(double fuelQuantity)
        {
            this.FuelQuantity += fuelQuantity;
            return $"{this.Make} {this.Model} refuiling with {fuelQuantity}...-> current fuel: {this.FuelQuantity}";
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\n\tModel: {this.Model}\n\tYear: {this.Year}\n\tHorsePowers: {this.Engine.HorsePower}\n\tFuelQuantity: {this.FuelQuantity}";
        }
    }
}
