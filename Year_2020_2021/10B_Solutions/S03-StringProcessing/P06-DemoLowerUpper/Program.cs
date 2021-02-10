using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Upper: {input.ToUpper()}");
        Console.WriteLine($"Lower: {input.ToLower()}");
    }
}

