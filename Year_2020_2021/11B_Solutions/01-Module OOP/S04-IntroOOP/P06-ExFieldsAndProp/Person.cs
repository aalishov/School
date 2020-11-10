using System;

public class Person
{
    private string name;

    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name can't be empty string!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value <= 0 || value >= 120)
            {
                throw new ArgumentException("Age must be between [1;120]!");
            }
            this.age = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Age}";
    }
}

