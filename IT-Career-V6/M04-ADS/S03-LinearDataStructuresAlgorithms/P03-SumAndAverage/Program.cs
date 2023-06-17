using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();

        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }

        double average = sum / (double)list.Count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
    }
}