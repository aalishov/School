using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> list = Console.ReadLine()
            .Split('|')
            .ToList();
        List<int> nums = new List<int>();
        for (int i = list.Count - 1; i >= 0; i--)
        {
            List<int> currentNums = list[i]
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
           nums.AddRange(currentNums);
        }
        Console.WriteLine(String.Join(" ", nums));
    }
}