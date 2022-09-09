using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        Count++;
    }
    public static int Count { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public static string CountMessage()
    {
        return $"Class \"Person\" objects count: {Count}";
    }
    public override string ToString()
    {
        return $"Name: {this.Name}, age: {this.Age}";
    }
}

