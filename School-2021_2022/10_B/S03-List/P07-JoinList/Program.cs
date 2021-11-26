using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> lists = Console.ReadLine()
            .Split('|')
            .ToList();
        List<int> nums = new List<int>();

        for (int i = lists.Count - 1; i >= 0; i--)
        {
            List<int> currentNums = lists[i]
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            nums.AddRange(currentNums);
        }
        Console.WriteLine(string.Join(" ",nums));
    }
}

