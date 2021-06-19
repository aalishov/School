using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 15, 3, 100, 16, 25 };

        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min) { min = nums[i]; }
            if (nums[i] > max) { max = nums[i]; }
        }

        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
    }
}

