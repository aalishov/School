using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Person firstPerson = new Person()
        {
            Name = "Иван",
            Age = 15,
            Address = "Велинград, Кристал №12"
        };
        Person secondPerson = new Person()
        {
            Name = "Пешо",
            Age = 30,
            Address = "Велинград, Кристал №13"
        };
        Person thirdPerson = new Person()
        {
            Name = "Ники",
            Age = 30,
            Address = "Велинград, Кристал №14"
        };
        List<Person> people = new List<Person>();
        people.Add(firstPerson);
        people.Add(secondPerson);
        people.Add(thirdPerson);

        foreach (var person in people)
        {
            person.IntroduceYourself();
            person.PrintAddress();
        }

        foreach (var person in people)
        {
            person.Grow();
            person.Grow();
        }
    }
}

