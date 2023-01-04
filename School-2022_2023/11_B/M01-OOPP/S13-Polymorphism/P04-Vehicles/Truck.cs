using System;
using System.Collections.Generic;
using System.Text;

public class Truck:Vehicle
{
    public override double FuelConsumpiton
    {
        get { return base.FuelConsumpiton; }
        set
        {
            base.FuelConsumpiton = value + 1.6;
        }
    }
    public override void Refuel(double fuelQuantity)
    {
        fuelQuantity *= 0.95;
        base.Refuel(fuelQuantity);  
    }
}

