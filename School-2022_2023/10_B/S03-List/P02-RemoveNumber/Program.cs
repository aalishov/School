using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();
        int remove = int.Parse(Console.ReadLine());

        while (nums.Any(x => x == remove))
        {
            nums.Remove(remove);
        }
        //for (int i = 0; i < nums.Count; i++)
        //{
        //    if (nums[i]==remove)
        //    {
        //        nums.Remove(remove);
        //        i--;
        //    }
        //}

        Console.WriteLine(String.Join(", ", nums));
    }
}

