using System;
using System.Collections.Generic;
using System.Text;

public class Mammal
{
    public void Eat()
    {
        Console.WriteLine($"{GetType().Name} is eating...");
    }
}

