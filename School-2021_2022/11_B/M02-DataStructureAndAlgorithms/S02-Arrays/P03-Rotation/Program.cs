using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int first = nums[0];
            for (int j = 0; j < nums.Length-1; j++)
            {
                nums[j] = nums[j + 1];
            }
            nums[nums.Length - 1] = first;
        }
        Console.WriteLine(string.Join(" ",nums));
    }
}

