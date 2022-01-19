using System;
using System.Collections.Generic;

namespace P00_DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog("", 15);
            IAnimal fish = new Fish("", 2);
            IAnimal bird = new Bird("", 3);

            List<IAnimal> animals = new List<IAnimal>() { dog, fish, bird };

            foreach (var animal in animals)
            {
                animal.Move();
                animal.Breathe();
            }
        }
    }
}
