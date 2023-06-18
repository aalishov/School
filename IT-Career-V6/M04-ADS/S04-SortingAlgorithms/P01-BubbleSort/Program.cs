using System;


public class Program
{
    public static void Main()
    {
        int[] nums = { 65, 7, 15, 0, -4, 23, 47, 25, 86, 0, 154, 23, -74, 25, 65, 47 };

        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1 - i; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                }
                count++;
            }
        }

        Console.WriteLine($"Iteration: {count}");
        Console.WriteLine(string.Join(", ", nums));
    }
}

