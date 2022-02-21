using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello \n\r World!");
        Console.WriteLine($"Hello {Environment.NewLine} World!");
        Console.WriteLine("Hello\tWorld!");
        Console.WriteLine("Hello \"World\"!");
        Console.WriteLine($"Hello {{World}}!");

        double result = 25.6845646465;
        Console.WriteLine($"{result:f2}");
        Console.WriteLine($"{result:f12}");
        Console.WriteLine($"{result:c2}");
    }
}

