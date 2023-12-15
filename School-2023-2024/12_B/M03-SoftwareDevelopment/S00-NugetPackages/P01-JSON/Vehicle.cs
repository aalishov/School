using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vehicle
{
    public string Id { get; set; } 
    public string Brand { get; set; }
    public string Model { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, brand: {Brand}, model: {Model}";
    }
}

