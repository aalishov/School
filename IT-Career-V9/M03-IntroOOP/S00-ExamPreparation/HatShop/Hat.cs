using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Hat
{
    private double price;

    public Hat(string type, string color, double price)
    {
        Type = type;
        Color = color;
        Price = price;
    }

    public string Type { get; private set; }

    public string Color { get; private set; }

    public double Price
    {
        get => price;
        private set
        {
            if (value > 100)
            {
                throw new ArgumentException("Invalid hat price!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        return $"Hat {Type} with color {Color} costs {Price:f2}";
    }
}
