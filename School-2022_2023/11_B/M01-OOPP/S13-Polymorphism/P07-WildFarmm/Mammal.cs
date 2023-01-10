using System;
using System.Collections.Generic;
using System.Text;
public abstract class Mammal : Animal
{
    protected Mammal(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion { get; private set; }
}

