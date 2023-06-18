using System;


public class Program
{
 public   static void Main()
    {
        int[] nums = { 65, 7, 15, 0, -4, 23, 47, 25, 86, 0, 154, 23, -74, 25, 65, 47 };

        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int min = i;
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[min] > nums[j])
                {
                    min = j;
                    count++;
                }
                count++;
            }
            int temp = nums[i];
            nums[i] = nums[min];
            nums[min] = temp;
            count++;
        }

        Console.WriteLine($"Iteration: {count}");
        Console.WriteLine(string.Join(", ",nums));
    }
}

