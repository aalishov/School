using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic
{
    public class Pet
    {
        public Pet(string name, int age, string owner)
        {
            Name = name;
            Age = age;
            Owner = owner;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Owner { get; private set; }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age} Owner: {Owner}";
        }
    }
}
