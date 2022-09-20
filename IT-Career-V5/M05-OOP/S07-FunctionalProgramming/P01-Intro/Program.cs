using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

        //int[] nums2 = nums.Select(x => x + 3).ToArray();

        //Console.WriteLine(String.Join(" ",nums2));

        Func<int, int> func = x => x * 2 + new Random().Next(-100, 100);

        int[] nums2 = nums.Select(x => func(x)).ToArray();
        Console.WriteLine(String.Join(" ", nums2));
    }
}

