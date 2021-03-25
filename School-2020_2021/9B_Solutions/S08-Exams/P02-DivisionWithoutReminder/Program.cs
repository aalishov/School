using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int p1 = 0, p2 = 0, p3 = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number [{i}]: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) { p1++; }
            if (number % 3 == 0) { p2++; }
            if (number % 4 == 0) { p3++; }
        }

        Console.WriteLine($"p1 = {p1 / (double)n:p2}");
        Console.WriteLine($"p2 = {p2 / (double)n:p2}");
        Console.WriteLine($"p3 = {p3 / (double)n:p2}");
    }
}

