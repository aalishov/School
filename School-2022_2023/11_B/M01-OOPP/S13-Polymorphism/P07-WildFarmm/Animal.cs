using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{
    private double weight;

    protected Animal(string name, double weight, int foodEaten)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = foodEaten;
    }

    public string Name { get; private set; }
    public virtual double Weight
    {
        get { return weight; }
        private set
        {
            weight = value;
        }
    }
    public int FoodEaten { get; private set; }

    public abstract string MakeNoise();
}

