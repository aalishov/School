using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Brand { get; set; }
    public string Model { get; set; }
    public Color Color { get; set; }
    public Tyre[] Tyres { get; set; }
}

public class Tyre
{
    public double Pressure { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
}

