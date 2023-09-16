using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private int age;

    public Person()
    {
        Count++;
    }

    public Person(string firstName) : this()
    {
        FirstName = firstName;
    }

    public Person(string firstName, int age) : this(firstName)
    {
        Age = age;
    }

    public static int Count { get; private set; }
    public string FirstName { get; private set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Invalid {nameof(Age)}!");
            }
            age = value;
        }
    }

    public void Grow(int age = 1)
    {
        this.Age += age;
    }

    public static string GetCountAsString()
    {
        return $"Person count: {Count}";
    }

    public string IntroduceYourself()
    {
        return $"Здравейте! Аз съм {FirstName} и съм на {Age} години.";
    }

    public override string ToString()
    {
        return IntroduceYourself();
    }

}

