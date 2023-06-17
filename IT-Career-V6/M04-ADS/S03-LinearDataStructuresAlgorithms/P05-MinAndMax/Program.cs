using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums=Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max) { max = nums[i]; }
            if (nums[i] < min) { min = nums[i]; }
        }

        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
    }
}