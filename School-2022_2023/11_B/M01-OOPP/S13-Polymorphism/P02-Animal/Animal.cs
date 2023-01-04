using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal
{
    protected Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public string Name { get; private set; }
    public string FavoriteFood { get; private set; }

    public abstract string ExplainSelf();
}

