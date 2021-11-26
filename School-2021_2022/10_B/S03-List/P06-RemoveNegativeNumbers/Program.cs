using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        nums.RemoveAll(x => x < 0);

        if (nums.Count > 0)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
        else { Console.WriteLine("empty"); }
    }
}

