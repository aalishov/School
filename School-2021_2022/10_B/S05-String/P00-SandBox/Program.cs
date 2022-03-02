using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string path = "data.txt";

        string[] data= File.ReadAllLines(path);

        for (int i = 0; i < data.Length; i++)
        {
            string[] info = data[i].Split(" ") ;
            string name = info[0];
            int age = int.Parse(info[1]);
            people.Add(new Person(name, age));
        }

        List<string> newData = new List<string>();
        foreach (var person in people)
        {
            person.Grow();
            newData.Add(person.WriteInFIle());
        }


        File.WriteAllLines(path, newData.ToArray());
        Console.WriteLine(string.Join($"{Environment.NewLine}",people));
    }
}

class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public void Grow()
    {
        this.Age++;
    }

    public  string WriteInFIle()
    {
        return $"{this.Name} {this.Age}";
    }

    public override string ToString()
    {
        return $"Name: {this.Name}, age: {this.Age}";
    }
}

