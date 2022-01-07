using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<int> nums = CreateList();
        Console.WriteLine(string.Join(", ", nums));
        Console.WriteLine(new string('*', 30));
        Console.WriteLine($"Sum abs 30: {SumAbs30(nums)}");
    }
    public static int ProductOdd(List<int> nums)
    {
        List<int> filter = nums.Where(x => x % 2 == 1 && x != 0).ToList();
        int product = 1;
        for (int i = 0; i < filter.Count; i++)
        {
            product *= filter[i];
        }
        return product;
    }
    public static int SumAbs30(List<int> nums)
    {
        return nums.Where(x => Math.Abs(x) > 30).Sum();
    }
    public static List<int> CreateList()
    {
        Random r = new Random();
        List<int> nums = new List<int>();
        for (int i = 0; i < 50; i++)
        {
            nums.Add(r.Next(-100, 100));
        }
        return nums;
    }
}

