using System;

public class Program
{
    static void Main()
    {
        Animal dog = new Dog("Gosho", "Meat");
        Animal cat = new Cat("Pesho", "Whiskas");

        Console.WriteLine(cat.ExplainSelf());
        Console.WriteLine(dog.ExplainSelf());
    }
}

