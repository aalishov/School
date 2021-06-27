using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    public Vehicle(string brand, string model, int horsePower, double fuel)
    {
        this.Brand = brand;
        this.Model = model;
        this.HorsePower = horsePower;
        this.Fuel = fuel;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; private set; }
    public double Fuel { get; private set; }
    public virtual double FuelConsumption { get => 1.25; }

    public void Drive(double kilometres)
    {
        double neededFuel = kilometres * FuelConsumption;
        if (neededFuel>Fuel)
        {
            throw new InvalidOperationException("Not enaugh fuel!");
        }
        this.Fuel -= neededFuel;
    }
}

