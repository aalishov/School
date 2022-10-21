using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Array.Sort(nums);

        Console.WriteLine(String.Join(", ",nums));
    }
}

