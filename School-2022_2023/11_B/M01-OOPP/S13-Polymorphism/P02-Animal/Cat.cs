using System;
using System.Collections.Generic;
using System.Text;


public class Cat : Animal
{
    public Cat(string name, string favoriteFood) : base(name, favoriteFood)
    {
    }

    public override string ExplainSelf()
    {
        return ($"I am {Name} and my fovourite food is {FavoriteFood} \nMEEOW");
    }
}

