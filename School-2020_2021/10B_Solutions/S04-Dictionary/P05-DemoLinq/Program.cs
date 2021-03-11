using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 5, 12, 3, -12, 12, 21 };
        Console.WriteLine($"Array: {string.Join(", ",numbers)}");
        Console.WriteLine($"Max: {numbers.Max()}");
        Console.WriteLine($"Average: {numbers.Average()}");
        Console.WriteLine($"Sorted (a-z): {string.Join(", ",numbers.OrderBy(x=>x))}");
        Console.WriteLine($"Sorted (z-a): {string.Join(", ", numbers.OrderByDescending(x => x))}");
        Console.WriteLine($"Skip 2, take 2: {string.Join(", ", numbers.Skip(2).Take(2))}");
    }
}

