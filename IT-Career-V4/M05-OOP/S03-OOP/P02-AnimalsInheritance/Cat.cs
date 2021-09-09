using System;
using System.Collections.Generic;
using System.Text;

namespace P02_AnimalsInheritance
{
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name} => Meowing...");
        }
    }
}
