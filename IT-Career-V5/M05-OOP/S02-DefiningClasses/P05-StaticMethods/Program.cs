using System;

public class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("John", 12);
        Person p2 = new Person("Jane", 15);
        Person p3 = new Person("Jane", 15);

        Console.WriteLine(Person.CountMessage());
    }

    public static void Print()
    {
        Console.WriteLine(new String('*',20));
    }
}
