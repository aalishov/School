using System;

public class Program
{
    public static void Main()
    {
        double sum = 0.0;

        Console.Write("Enter number or end: ");
        string input = Console.ReadLine();
        while (input != "end")
        {
            sum += double.Parse(input);
            Console.Write("Enter number or end: ");
            input = Console.ReadLine();
        }
        Console.WriteLine($"Sum: {sum}");
    }
}

