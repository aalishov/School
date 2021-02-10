using System;

public class Program
{
    public static void Main()
    {
        Dog dog = new Dog();
        Console.WriteLine(dog.Eat());
        Console.WriteLine(dog.Bark());

        Cat cat = new Cat();
        Console.WriteLine( cat.Eat());
        Console.WriteLine(cat.Meow());
    }
}

