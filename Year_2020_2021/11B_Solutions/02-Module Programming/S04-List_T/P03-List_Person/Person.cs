using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {this.Name}, age: {this.Age}";
    }
}

