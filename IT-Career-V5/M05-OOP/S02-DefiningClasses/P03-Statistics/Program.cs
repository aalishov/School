using System;

public class Program
{
    static void Main(string[] args)
    {
        Family family = new Family();

        Console.Write("Enter family count: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person() { Name = name, Age = age };
            family.AddMember(person);
        }
        Console.WriteLine(family.Report());
    }
}

