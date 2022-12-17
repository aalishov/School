using System;

internal class Program
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        string lower=input.ToLower();
        Console.WriteLine($"Text to lower: {lower}");

        string upper=input.ToUpper();
        Console.WriteLine($"Text to upper: {upper}");
    }
}

