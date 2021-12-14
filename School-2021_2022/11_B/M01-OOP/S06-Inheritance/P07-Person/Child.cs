using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Person
{
    public class Child : Person
    {
        public Child(string name, int age, Person mother, Person father) : base(name, age)
        {
            this.Mother = mother;
            this.Father = father;
        }

        public Person Mother { get; set; }
        public Person Father { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Mother: {this.Mother.Name}, Father: {this.Father.Name}";
        }
    }
}
