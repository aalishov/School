using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(", ")
            //.Split(new char[] {' ',',' },StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int needed = nums.Length / 2 + 1;

        Dictionary<int, int> elementsCount = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (elementsCount.ContainsKey(nums[i])) { elementsCount[nums[i]]++; }
            else { elementsCount.Add(nums[i], 1); }
        }

        string result = "The majorant does not exists!";

        foreach (var item in elementsCount)
        {
            if (item.Value>=needed)
            {
                result = item.Key.ToString();
                break;
            }
        }

        Console.WriteLine(result);
    }
}

