using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Backwards(new int[] { 1, 7, 8 });


    }
    static void Backwards(int[] nums)
    {
        for (int i = nums.Length; i >= 0; i++)
        {
            Console.Write($"{nums[i]} ");
        }
    }
}

