using System;

public class Program
{
    static void Main()
    {
        Citizen c = new Citizen("1","Mark",35,"04.07.1999");

        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();

        IIdentifiable identifiable = new Citizen(id, name, age, birthdate);
        IBirthable birthable = new Citizen(id, name, age, birthdate);

        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthable.Birthdate);
    }
}

