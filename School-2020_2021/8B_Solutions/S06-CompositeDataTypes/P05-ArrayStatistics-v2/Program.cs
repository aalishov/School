using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter elements");
        double[] nums = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        //Print Output
        Console.WriteLine($"Max: {nums.Max()}");
        Console.WriteLine($"Min: {nums.Min()}");
        Console.WriteLine($"Sum: {nums.Sum()}");
        Console.WriteLine($"Average: {nums.Average():f3}");

    }
}

