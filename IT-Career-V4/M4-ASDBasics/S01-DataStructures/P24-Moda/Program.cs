using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numsCount.ContainsKey(nums[i])) { numsCount[nums[i]]++; }
            else { numsCount.Add(nums[i], 1); }
        }

        int max = 0;
        int? moda = null;

        foreach (var item in numsCount)
        {
            if (item.Value > max)
            {
                max = item.Value;
                moda = item.Key;
            }
        }

        if (numsCount.Count(x => x.Value == max) > 1)
        {
            Console.WriteLine(numsCount.Where(x=>x.Value==max).Average(x=>x.Key));
        }
        else
        {
            Console.WriteLine(moda);
        }

    }
}

