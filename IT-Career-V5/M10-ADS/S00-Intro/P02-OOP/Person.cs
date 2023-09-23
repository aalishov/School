using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    public Person(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public override string ToString()
    {
        return $"{this.GetType().Name} name: {this.Name}";
    }
}

