using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Furniture
{
    public Furniture(string type, string color, double price)
    {
        this.Type = type;
        this.Color = color;
        this.Price = price;
    }

    public string Type { get;private set; }
    public string Color { get;private set; }
    public double Price { get;private set; }

    public override string ToString()
    {
        return $"Furniture {Type} with color {Color} costs {Price:f2}";
    }
}

