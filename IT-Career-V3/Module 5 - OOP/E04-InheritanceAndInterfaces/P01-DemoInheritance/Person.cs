using System;
using System.Collections.Generic;
using System.Text;

namespace P01_DemoInheritance
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string IntroduceYourself()
        {
            return $"Hi! I'm {this.Name}!";
        }
    }
}
