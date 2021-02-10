using System;

public class Person
{
    //Полета
    private string name;
    private int age;

    //Конструктор
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    //Свойства
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

    //Метод

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

