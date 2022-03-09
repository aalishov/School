using System;

public class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{new string(' ',n-i)}{new string('*', i)}");
        }
    }
}

