using System;
using System.Collections.Generic;
using System.Text;

public class Tiger : Feline
{
    public Tiger(string name, double weight, int foodEaten, string livingRegion, string bread) : base(name, weight, foodEaten, livingRegion, bread)
    {
    }

    public override string MakeNoise()
    {
        return "ROAR!!!";
    }
}

