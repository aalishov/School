using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine($"list [{i}] = {nums[i]}");
        }
    }
}

