using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private int age;
    private string name;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get
        {
            return name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new PersonException(nameof(Name));
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value <= 0)
            {
                throw new PersonException(nameof(Age));
            }
            age = value;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, age: {Age}";
    }
}

