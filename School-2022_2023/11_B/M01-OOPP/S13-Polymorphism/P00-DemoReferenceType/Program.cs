using System;

public class Program
{
    static void Main()
    {
        IAnimal animal = new Dog("Sharo 1", 5);
        Mammal mammal = new Dog("Sharo 2", 3);
        Dog dog = new Dog("Sharo 3", 4);

        ((Dog)animal).Eat();
        Console.WriteLine(((Dog)mammal).Age);
    }
}

