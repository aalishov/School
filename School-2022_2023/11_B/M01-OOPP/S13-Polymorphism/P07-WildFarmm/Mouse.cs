using System;
using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
    {
    }

    public override string MakeNoise()
    {
       return "Squeak";
    }
    public override string ToString()
    {
        return $"{GetType().Name} [{ this.Name}, { this.Weight}, { this.LivingRegion}, { this.FoodEaten}]"; 
    }
}

