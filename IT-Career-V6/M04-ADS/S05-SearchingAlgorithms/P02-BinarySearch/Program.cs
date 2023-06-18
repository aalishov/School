using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { -15, -7, -2, 0, 5, 8, 16, 23, 25, 48, 89 };


        int num = 1;

        int index = -1;

        int start = 0;
        int end = nums.Length - 1;

        while (end >= start)
        {
            int mid = (start + end) / 2;

            if (nums[mid] < num)
            {
                start = mid + 1;

            }
            else if (nums[mid] > num)
            {
                end = mid - 1;
            }
            else
            {
                index = mid;
                break;
            }
        }

        Console.WriteLine(index);
    }
}