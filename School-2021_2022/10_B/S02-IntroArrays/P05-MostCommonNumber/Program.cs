using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        //1 2 1 4 3 4 4 1 2 4 9

        int maxElement = 0;
        int maxCount = 0;
        int currentCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    currentCount++;
                }
            }
            if (currentCount>maxCount)
            {
                maxCount = currentCount;
                maxElement = nums[i];
            }
        }

        Console.WriteLine($"Max count = {maxCount}");
        Console.WriteLine($"Max element = {maxElement}");
    }
}

