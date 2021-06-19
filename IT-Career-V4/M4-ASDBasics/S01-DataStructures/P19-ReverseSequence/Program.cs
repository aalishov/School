using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Stack<int> nums = new Stack<int>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            nums.Push(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine("-----");
        while (nums.Count > 0)
        {
            Console.WriteLine(nums.Pop());
        }
    }
}

