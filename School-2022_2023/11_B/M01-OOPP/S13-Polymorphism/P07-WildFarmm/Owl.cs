using System;
using System.Collections.Generic;
using System.Text;

public class Owl : Bird
{
    public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {
    }

    public override string MakeNoise()
    {
        return "Hoot Hoot";
    }
}

