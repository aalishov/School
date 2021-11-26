using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 5, 2, 3, 2, 4, 9 };
        //nums.Remove(2);
        //nums.RemoveAll(x => x % 2 == 1);
        nums = nums.Select(x => x - 2).ToList();
        nums.RemoveAll(x => x <= 0);
        Console.WriteLine(nums.Count);
    }
}

