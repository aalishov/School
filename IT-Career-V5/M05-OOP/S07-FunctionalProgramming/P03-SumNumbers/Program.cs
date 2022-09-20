using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(", ")
            .Select(x => int.Parse(x))
            .ToArray();
        Console.WriteLine(nums.Count());
        Console.WriteLine(nums.Sum());
    }
}

