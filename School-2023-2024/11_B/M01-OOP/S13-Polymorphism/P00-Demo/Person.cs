using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_Demo
{
    public class Person : Mammal
    {
        public Person(string name, int age) : base(age)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public override string Color { get => "Red"; set => base.Color = "Red"; }

        public override string Print()
        {
            return $"My name is {Name}, my color is: {Color}";
        }
    }
}
