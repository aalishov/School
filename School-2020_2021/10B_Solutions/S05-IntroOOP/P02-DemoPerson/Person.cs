using System;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Address { get; set; }

    public void IntroduceYourself()
    {
        Console.WriteLine($"Здравейте! Аз съм {Name} и съм на {Age} години.");
    }

    public void PrintAddress()
    {
        Console.WriteLine($"Аз съм {Name} и живея на адрес: {Address}");
    }

    public void Grow()
    {
        Age++;
        Console.WriteLine($"{Name} става на {Age} години!");
    }
}

