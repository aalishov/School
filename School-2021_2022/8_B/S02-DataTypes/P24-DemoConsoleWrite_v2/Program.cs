using System;

public class Program
{
    public static void Main()
    {
        string name = "John";
        string town = "London";
        //I'am John from London

        //Variant 1
        Console.Write("I'am ");
        Console.Write(name);
        Console.Write(" from ");
        Console.WriteLine(town);

        //Variant 2
        Console.WriteLine("I'am {0} from {1}", name, town);

        //Variant 3
        Console.WriteLine("I'am " + name + " from " + town);

        //Variant 4
        Console.WriteLine($"I'am {name} from {town}");
    }
}

