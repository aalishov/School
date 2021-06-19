using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> nums = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

        SortedDictionary<int, int> numsCount = new SortedDictionary<int, int>();

        for (int i = 0; i < nums.Count; i++)
        {
            int element = nums[i];
            if (numsCount.ContainsKey(element)) { numsCount[element]++; }
            else { numsCount.Add(element, 1); }
        }

        foreach (var item in numsCount)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }

        List<int> result = new List<int>();

        for (int i = 0; i < nums.Count; i++)
        {
            int element = nums[i];
            if (numsCount.ContainsKey(element))
            {
                if (numsCount[element]%2==0)
                {
                    result.Add(element);
                }
            }
        }
        Console.WriteLine(string.Join(", ",result));
    }
}

