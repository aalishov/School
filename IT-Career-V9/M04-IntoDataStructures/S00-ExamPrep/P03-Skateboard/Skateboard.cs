using System;
using System.Collections.Generic;
using System.Text;


public class Skateboard
{
    public Skateboard(string model, double price)
    {
        Model = model;
        Price = price;
    }

    public string Model { get; private set; }

    public double Price { get; private set; }

    public override string ToString()
    {
        return $"Skateboard {Model} costs {Price:f2} lv.";
    }
}

