using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int maxCount = 0;
        int element = 0;
        int currentCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {

            }
        }
    }
}

