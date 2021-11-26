using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //List<int> nums = new List<int>();
        //nums.Add(10);
        //nums.Add(16);

        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        // nums.Add(100);
        // nums.Add(-10);
        // nums.Insert(0, -1);
        nums.Insert((nums.Count / 2 ), int.Parse(Console.ReadLine()));
        Console.WriteLine($"Remove(10) -> {nums.Remove(10)}");
        Console.WriteLine($"List count: {nums.Count}");

        Console.WriteLine(string.Join(", ", nums));
    }
}

