using System;

class Program
{
    static void Main()
    {
        Animal animal = new Animal() { Name = "Strange Animal", Age = 25 };
        Console.WriteLine(animal.Eat());

        Dog dog = new Dog();
        Console.WriteLine(dog.Bark());
        Console.WriteLine(dog.Eat());
        dog.Name = "Sharo";
        dog.Age = 15;

        Console.WriteLine(animal);
        Console.WriteLine(dog);
    }
}

