using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> nums = new List<int>();
        Console.WriteLine($"List count: {nums.Count}");
        for (int i = 0; i < n; i++)
        {
            nums.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine($"List count: {nums.Count}");
        }

        Console.WriteLine("Enter element: ");
        Console.WriteLine(nums.Remove(int.Parse(Console.ReadLine())));
        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine($"list [{i}] = {nums[i]}");
        }
    }
}

