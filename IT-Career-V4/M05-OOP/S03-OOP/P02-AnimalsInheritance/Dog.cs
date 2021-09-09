using System;
using System.Collections.Generic;
using System.Text;

namespace P02_AnimalsInheritance
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name} => Barking...");
        }
    }
}
