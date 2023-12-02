using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    private string name;
    private int age;

    public Employee()
    {
        Name = "No name";
        Age = 1;
    }

    public Employee(int age) : this()
    {
        Age = age;
    }

    public Employee(string name, int age) : this(age)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            age = value;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, age: {Age}";
    }
}

