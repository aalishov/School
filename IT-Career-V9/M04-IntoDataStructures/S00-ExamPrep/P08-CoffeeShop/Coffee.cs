using System;
using System.Collections.Generic;
using System.Text;


public class Coffee
{
    public Coffee(string type, double price)
    {
        Type = type;
        Price = price;
    }

    public string Type { get; private set; }

    public double Price { get; private set; }

    public override string ToString()
    {
        return $"Coffee {Type} costs {Price:F2} lv.";
    }
}

