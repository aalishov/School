namespace P02_DziCars
{
    using System;
    public class Car
    {
        public Car(string brand, int year, int mileage, double value)
        {
            this.Brand = brand;
            this.Year = year;
            this.Mileage = mileage;
            this.Value = value;
        }

        public string Brand { get; private set; }
        public int Year { get; private set; }
        public int Mileage { get; private set; }
        public double Value { get; private set; }

        public int Age { get => DateTime.UtcNow.Year - this.Year; }
        public virtual double Price()
        {
            double price = 0.0;
            if (this.Age <= 3)
            {
                price = this.Value * 0.8;
            }
            else if (this.Age > 3 && this.Age <= 6)
            {
                price = this.Value * 0.6;
            }
            else
            {
                price = this.Value * 0.3;
            }
            return Math.Round(price, 2);
        }

        public override string ToString()
        {
            return $"{this.Brand}: {this.Mileage} km, {Price():f2}";
        }
    }
}
