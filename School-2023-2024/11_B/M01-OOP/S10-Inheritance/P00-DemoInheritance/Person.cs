using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value<=0)
            {
                throw new ArgumentException("Invalid age!");
            }
            age = value;
        }
    }

    public override string ToString()
    {
        return $"Info - Name: {Name}, age: {Age}";
    }
}

