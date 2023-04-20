using System;

public class Program
{
    public static void Main()
    {
        int countP1 = 0; int countP2 = 0; int countP3 = 0; int countP4 = 0; int countP5 = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 200) { countP1++; }
            else if (num < 400) { countP2++; }
            else if (num < 600) { countP3++; }
            else if (num < 800) { countP4++; }
            else { countP5++; }
        }

        Console.WriteLine($"{countP1 / (double)n * 100.0:f2}%");
        Console.WriteLine($"{countP2 / (double)n * 100.0:f2}%");
    }
}

