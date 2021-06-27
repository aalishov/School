using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{
    protected Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public void Grow()
    {
        this.Age++;
    }

    public string Eating()
    {
        return $"{this.GetType().Name} {this.Name} eating...";
    }

    public override string ToString()
    {
        return $"I'm a {this.GetType().Name}, my name is {this.Name} and I'm {this.Age} years old!";
    }
}

