using System;
using System.Collections.Generic;
using System.Text;

namespace P06_ExInheritanceZoo
{
    //abstract - не може да създаваме обекти от този клас
    //sealed - класа не може да има наследници
    public abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
