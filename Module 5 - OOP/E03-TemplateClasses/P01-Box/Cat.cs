using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Box
{
    public class Cat
    {
        public Cat(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
