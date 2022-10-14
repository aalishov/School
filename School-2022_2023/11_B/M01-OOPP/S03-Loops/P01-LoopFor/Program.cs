using System;


internal class Program
{
    static void Main()
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int n=int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num>max) { max = num; }
            if (num < min) { min = num; }
        }

        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
    }
}

