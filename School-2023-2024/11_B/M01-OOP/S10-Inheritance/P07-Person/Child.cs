using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Child : Person
{
    public Child(string name, int age, Person mother, Person fater) : base(name, age)
    {
        Mother = mother;
        Father = fater;
    }

    public Person Mother { get; set; }
    public Person Father { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", father: {Father.ToString()}, mother: {Mother.ToString()}";
    }
}

