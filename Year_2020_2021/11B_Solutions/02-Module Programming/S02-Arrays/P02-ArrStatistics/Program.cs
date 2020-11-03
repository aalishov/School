using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine()
            .Split(' ')
            .Select(x=>double.Parse(x)*2+1)
            .ToArray();
        //double[] nums = new double[] { 2, 3, 4 };

        Console.WriteLine($"Arr: {string.Join(" | ",nums)}");
        Console.WriteLine($"Length: {nums.Length}");
        Console.WriteLine($"Min: {nums.Min()}");
        Console.WriteLine($"Max: {nums.Max()}");
        Console.WriteLine($"Sum: {nums.Sum()}");
        Console.WriteLine($"Average: {nums.Average()}");
    }
}

