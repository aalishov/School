using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<double> nums = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();
        Dictionary<double, int> count = new Dictionary<double, int>();

        for (int i = 0; i < nums.Count; i++)
        {
            double element = nums[i];
            if (count.ContainsKey(element))
            {
                count[element]++;
            }
            else
            {
                count.Add(element, 1);
            }
        }
        Console.WriteLine($"{"Element",7} => {"Count",5}");
        foreach (var pair in count)
        {
            Console.WriteLine($"{pair.Key,7} => {pair.Value,5}");
        }
    }
}

