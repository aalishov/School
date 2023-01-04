using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Animal
{
    public override void Eat()
    {
        base.Eat();
        MakeNoise();
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Meow...");
    }
}

