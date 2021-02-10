using System;

public class Program
{
    public static void Main()
    {
        //Създаване на обекти от тип Person
        Person p1 = new Person("Ivan", 15);

        Person p2 = new Person("Pesho", 30);

        Person p3 = new Person("Ani", 28);

        Person p4 = new Person("Nadq", 70);

        Family family = new Family("Ivanovi");

        Console.WriteLine(family.AddMemebr(p1));
        Console.WriteLine(family.AddMemebr(p2));
        Console.WriteLine(family.AddMemebr(p3));
        Console.WriteLine(family.AddMemebr(p4));

        Console.WriteLine(family.GetOldestMember());
        Console.WriteLine(family.GetYoungestMember());

        Console.WriteLine(family.PrintFamilyInfo());
        Console.WriteLine(p3.Grow());
        family.Grow();
        Console.WriteLine(family.PrintFamilyInfo());
    }
}

