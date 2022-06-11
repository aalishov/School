using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Furniture
{
    public string Type { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Type: {this.Type}, color {this.Color}, price {this.Price:c2}";
    }
}

