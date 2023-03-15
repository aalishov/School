using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter numbers count: ");
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number {i}: ");
            int num = int.Parse(Console.ReadLine());
            sum += num;
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Average: {sum /(double)n:f2}");
    }
}

