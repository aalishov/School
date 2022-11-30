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

        nums.RemoveAll(x => x < 0);

        if (nums.Any())
        {
            Console.WriteLine(String.Join(", ", nums));
        }
        else
        {
            Console.WriteLine("Empty");
        }
    }
}