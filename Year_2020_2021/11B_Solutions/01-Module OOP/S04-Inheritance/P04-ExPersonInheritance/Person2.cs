using System;

public class Person2
{
    private string name;
    private int age;

    public Person2(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name is invalid!");
            }
            name = value;
        }
    }
    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentException("Invalid age!");
            }
            age = value;
        }
    }


    public string Grow()
    {
        this.Age++;
        return $"{this.Name} grow up!";
    }
    public override string ToString()
    {
        return $"Name: {this.Name} => age: {this.Age}";
    }
}