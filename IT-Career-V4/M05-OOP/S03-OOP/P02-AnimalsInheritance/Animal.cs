using System;
using System.Collections.Generic;
using System.Text;

namespace P02_AnimalsInheritance
{
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} => Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} => Sleeping...");
        }
    }
}
