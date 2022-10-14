using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine() //"5 10 15 -5"
            .Split(' ') // ["5", "10", "15", "-5"]
            .Select(int.Parse) //[5, 10, 15, 5]
            .ToArray();

        Console.WriteLine($"Min = {MyMin(nums)}");
        Console.WriteLine($"Max = {MyMax(nums)}");
        Console.WriteLine($"Sum = {MySum(nums)}");
        Console.WriteLine($"Average = {MyAverage(nums)}");
    }
    public static double MyAverage(int[] nums)
    {
        int sum = MySum(nums);
        return sum / (double)nums.Length;
    }
    public static int MySum(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    public static int MyMin(int[] nums)
    {
        int min = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }
        return min;
    }
    public static int MyMax(int[] nums)
    {
        int max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i])
            {
                max = nums[i];
            }
        }
        return max;
    }
}

