using System;
using System.Collections.Generic;
using System.Text;

public class Hen : Bird
{
    public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
    {
    }
    public override double Weight => base.Weight+FoodEaten*0.35;
    public override string MakeNoise()
    {
        return "Cluck";
    }
}

