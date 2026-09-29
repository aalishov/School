using System;

public class Program
{
    public static void Main()
    {
        int[] nums = { 15, 20, -5, 4, 12, 6, 75, 342, 0, 19, 18 };

        int num = -2;

        int index = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]==num)
            {
                index = i;
                break;
            }
        }

        Console.WriteLine(index);
    }
}