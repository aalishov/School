using System;
using System.Collections.Generic;
using System.Text;

namespace P04_NeedForSpeed
{
    public abstract class Vehicle
    {
        private double totalKilometres;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public double TotalKilometres
        {
            get { return this.totalKilometres; }
            private set
            {
                this.totalKilometres = value; 
            }
        }

        public virtual double FuelConsumption { get { return 1.25; } }

        public string Drive(double kilometers)
        {
            double neededFuel = kilometers * FuelConsumption/100.0;
            if (neededFuel <= this.Fuel)
            {
                this.Fuel -= neededFuel;
                this.TotalKilometres += kilometers;
                return $"{this.GetType().Name} traveled {kilometers} kilometers,current fuel: {this.Fuel}, total traveled distance: {this.TotalKilometres}";
            }
            else
            {
                double refuel = neededFuel - this.Fuel;
                return $"{this.GetType().Name} not enaugh fuel, current fuel: {this.Fuel}, please refuel min {refuel} litres to traveled {kilometers};";
            }
        }
    }
}
