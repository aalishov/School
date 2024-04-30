using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Truck : Car
{
    public Truck(string brand, int year, int mileage, double value, int tonnage) : base(brand, year, mileage, value)
    {
        Tonnage = tonnage;
    }

    public int Tonnage { get; set; }

    public override double Price()
    {
        if (DateTime.Now.Year - Year <= 5)
        {
            return Value;
        }
        else if (Tonnage <= 5)
        {
            return Value * 0.3;
        }
        else if (Tonnage > 10)
        {
            return Value * 0.8;
        }
        else
        {
            return Value * 0.6;
        }
    }
}

