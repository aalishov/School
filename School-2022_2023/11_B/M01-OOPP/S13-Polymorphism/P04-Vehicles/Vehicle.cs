using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    public double FuelQuantity { get;  set; }
    public virtual double FuelConsumpiton { get; set; }
    public string Drive(int distance)
    {
        double fuel = FuelConsumpiton * distance;
        if (fuel<=FuelQuantity)
        {
            FuelQuantity -= fuel;
            return $"{this.GetType().Name} travelled {distance} km";

        }
        return $"{this.GetType().Name} needs refueling";
    }
    public virtual void Refuel(double fuelQuantity) 
    {
        FuelQuantity += fuelQuantity;
    }
    public override string ToString()
    {
        return $"{this.GetType().Name}: {FuelQuantity:F2}";
    }
}

