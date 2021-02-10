using System;

public class Program
{
    public static void Main()
    {
        int a = 15;
        int b = 20;
        int sum = a + b;

        Console.WriteLine(a + " + " + b + " = " + sum);
        Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        Console.WriteLine($"{a} + {b} = {sum}");

        string name1 = "Pesho";
        string name2 = "Ivan";

        Console.WriteLine($"My name is {name1,8}"); //Дясно подравняване
        Console.WriteLine($"My name is {name2,8}"); //Дясно подравняване
        Console.WriteLine($"My name is {name1,-8}"); //Ляво подравняване
        Console.WriteLine($"My name is {name2,-8}"); //Ляво подравняване
    }
}

