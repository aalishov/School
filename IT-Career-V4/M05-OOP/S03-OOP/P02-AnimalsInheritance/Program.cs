using System;
using System.Collections.Generic;

namespace P02_AnimalsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal()
            {
                Name = "Mecho"
            };
            animal.Eat();

            Dog dog = new Dog() { Name = "Sharo" };
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat() { Name = "Tom" };

            Puppy puppy = new Puppy { Name = "Bali" };

            List<Animal> animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(puppy);

            foreach (var a in animals)
            {
                a.Sleep();
            }
        }
    }
}
