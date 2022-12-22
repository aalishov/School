using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Renault : ICar
{
    public Renault(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model { get; private set; }
    public string Color { get; private set; }
    public  string Start()
    {
        return $"{this.GetType().Name} engine start";
    }
    public string Stop()
    {
        return $"{this.GetType().Name} breaaak!";
    }
    public override string ToString()
    {
        return $"{this.Color} {this.GetType().Name} {this.Model}\n{Start()}\n{Stop()}";
    }
}

