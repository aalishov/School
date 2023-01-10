using System;
using System.Collections.Generic;
using System.Text;

public abstract class Feline : Mammal
{
    protected Feline(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed { get;private set; }

    public override string ToString()
    {
        return $"{GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}] ";
    }
}

