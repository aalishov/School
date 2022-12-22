using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Battery { get; private set; }
    public string Start()
    {
        return $"{this.GetType().Name} engine start";
    }
    public string Stop()
    {
        return $"{this.GetType().Name} breaaak!";
    }
    public override string ToString()
    {
        return $"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} batteries\n{Start()}\n{Stop()}";
    }
}

