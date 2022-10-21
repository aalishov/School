using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(nums);

        Console.WriteLine(String.Join(" ",nums));
    }
}

