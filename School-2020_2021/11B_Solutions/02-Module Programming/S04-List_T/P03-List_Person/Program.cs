using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        
        for (int i = 1; i <= 10; i++)
        {
            Random random = new Random();
            Person person = new Person();
            person.Age = random.Next(10,75);
            person.Name = $"Ivan{i}";
            people.Add(person);
        }

        Console.WriteLine($"People count: {people.Count}");

        Console.WriteLine(string.Join($"{Environment.NewLine}",people));
        Console.WriteLine("Сортирани по възраст:");
        Console.WriteLine(string.Join($"{Environment.NewLine}", people.OrderBy(x=>x.Age)));

        Console.WriteLine($"Oldest family member: {people.OrderBy(p=>p.Age).Last()}");
        Console.WriteLine($"Youngest family member: {people.OrderBy(p => p.Age).First()}");
        Console.WriteLine($"Average people age: {people.Average(p=>p.Age)}");
    }
}

