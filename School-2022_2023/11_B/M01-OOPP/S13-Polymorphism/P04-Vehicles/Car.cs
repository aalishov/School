using System;
using System.Collections.Generic;
using System.Text;

public class Car : Vehicle
{
    public override double FuelConsumpiton
    {
        get { return base.FuelConsumpiton; }
        set
        {
            base.FuelConsumpiton = value + 0.9;
        }
    } 
}

