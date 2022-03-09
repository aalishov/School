using System;

public class Program
{
    static void Main()
    {
        Console.Write("Enter count: ");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number>max)
            {
                max = number; 
            }
        }
        Console.WriteLine($"Max: {max}");
    }
}

