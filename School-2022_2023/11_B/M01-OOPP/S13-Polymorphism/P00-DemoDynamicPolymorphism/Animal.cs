using System;

public abstract class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine($"{GetType().Name} is eating...");
    }
    public abstract void MakeNoise();
}

