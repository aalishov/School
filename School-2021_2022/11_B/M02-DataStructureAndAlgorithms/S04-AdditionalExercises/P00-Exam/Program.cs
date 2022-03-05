using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        IList<int> first = new List<int>() { 15, 24, 12 };
        int[] second = new int[] { 15, 24, 12 };
        int firstL = first.Count;
        int secondL = second.Length;

        int firstLC = first.Count(x => x % 2 == 0);
        int secondLC = second.Count(x => x % 2 == 1);

        PrintElements(second);
    }
    public static void PrintElements(IEnumerable<int> nums)
    {
        foreach (var ele in nums)
        {
            Console.WriteLine($"@{ele}");
        }
    }
}

