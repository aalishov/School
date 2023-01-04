using System;

public class Program
{
    static void Main()
    {
        Animal cat = new Cat();
        Animal dog = new Dog();

        cat.MakeNoise();
        dog.MakeNoise();
    }
}

