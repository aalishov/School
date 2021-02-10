using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Krasi", 17);
        person.HairColor = "black";
        Person person1 = new Person("Gosho", 20);
        List<Person> people = new List<Person>() { person, person1 };
        Console.WriteLine(JsonConvert.SerializeObject(people,Formatting.Indented));
        File.WriteAllText("TextFile1.txt", JsonConvert.SerializeObject(people, Formatting.Indented));
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 100; i++)
        {
            sb.AppendLine(i.ToString());
        }
        File.WriteAllText("sb.txt",sb.ToString());
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

    public string HairColor { get; set; }
}
