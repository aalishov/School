using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> nums = new List<int>();

        while (true)
        {
            string input = Console.ReadLine();
            int element = 0;

            if (int.TryParse(input, out element)) { nums.Add(element); }
            else { break; }
        }

        //Вариант 1
        //Console.WriteLine(nums.Sum());
        //Console.WriteLine(nums.Average());

        //Вариант 2
        int sum = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            sum += nums[i];
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {sum / (double)nums.Count}");
    }

}

