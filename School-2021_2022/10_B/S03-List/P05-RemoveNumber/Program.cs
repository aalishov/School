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
        int removeNum = int.Parse(Console.ReadLine());

        nums.RemoveAll(x => x == removeNum);
        Console.WriteLine(string.Join(" ",nums));
    }
}

