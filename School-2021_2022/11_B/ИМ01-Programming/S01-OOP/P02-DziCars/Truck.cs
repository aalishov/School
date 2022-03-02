namespace P02_DziCars
{
    using System;
    public class Truck : Car
    {
        public Truck(string brand, int year, int mileage, double value, int tonnage) : base(brand, year, mileage, value)
        {
            this.Tonnage = tonnage;
        }
        public int Tonnage { get; private set; }

        public override double Price()
        {
            double price = 0.0;
            if (this.Age <= 5)
            {
                price = this.Value;
            }
            else if (this.Tonnage <= 5)
            {
                price = this.Value * 0.3;
            }
            else if (this.Tonnage > 5 && this.Tonnage <= 10)
            {
                price = this.Value * 0.6;
            }
            else
            {
                price = this.Value * 0.8;
            }
            return Math.Round(price, 2);
        }
    }
}
