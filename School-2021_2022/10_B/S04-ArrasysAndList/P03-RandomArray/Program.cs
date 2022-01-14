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
        Console.WriteLine($"Product odd: {ProductOdd(nums)}");
        Console.WriteLine($"Product even: {ProductEven(nums)}");
        Console.WriteLine($"Count even: {CountEvenIndex(nums)}");
    }
    public static int CountEvenIndex(List<int> nums)
    {
        int count = 0;
        for (int i = 0; i < nums.Count; i+=2)
        {
            if (nums[i] >= -30 && nums[i] <= 30)
            {
                count++;
            }
        }
        return count;
    }
    public static int ProductEven(List<int> nums)
    {
        List<int> filter = nums.Where(x => x % 2 == 0 && x != 0).ToList();
        int product = 1;
        for (int i = 0; i < filter.Count; i++)
        {
            product *= filter[i];
        }
        return product;
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
        for (int i = 0; i <8; i++)
        {
            nums.Add(r.Next(-100, 100));
        }
        return nums;
    }
}

