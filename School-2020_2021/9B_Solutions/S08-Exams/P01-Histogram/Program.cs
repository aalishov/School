using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number count: ");
        int n = int.Parse(Console.ReadLine());
        int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number [{i}]: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 200) { p1++; }
            else if (number >= 200 && number <= 399) { p2++; }
            else if (number >= 400 && number <= 599) { p3++; }
            else if (number >= 600 && number <= 799) { p4++; }
            else { p5++; }
        }

        Console.WriteLine($"p1 = {p1 / (double)n * 100.0:f2}%");
        Console.WriteLine($"p2 = {p2 / (double)n * 100.0:f2}%");
        Console.WriteLine($"p3 = {p3 / (double)n * 100.0:f2}%");
        Console.WriteLine($"p4 = {p4 / (double)n * 100.0:f2}%");
        Console.WriteLine($"p5 = {p5 / (double)n * 100.0:f2}%");
    }
}

