using System;
using System.Collections.Generic;
using System.Text;

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }
    public Dog(string name) : this(name, age: 1)
    {
    }

    public string Bark()
    {
        return $"{this.GetType().Name} {this.Name} barking...";
    }
}

