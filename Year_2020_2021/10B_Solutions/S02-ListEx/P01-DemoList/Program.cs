using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //int[] nums = new int[10]; //Масив

        //Console.WriteLine($"Array => {string.Join(", ", nums)}");
        //Console.WriteLine($"Array count: {nums.Length}");

        List<int> nums2 = new List<int>() { 2, 7 };//Списък

        nums2.Add(12);
        nums2.Add(-22);
        nums2.Add(15);

        Console.WriteLine($"List count: {nums2.Count}");
        Console.WriteLine($"List => {string.Join(", ", nums2)}");

        Console.WriteLine(new string('-', 50));

        bool isRemoved = nums2.Remove(15);
        bool isRemoved2 = nums2.Remove(150);
        Console.WriteLine($"isRemoved => {isRemoved}");
        Console.WriteLine($"isRemoved => {isRemoved2}");
        bool isContains = nums2.Contains(-22);
        Console.WriteLine($"isContains => {isContains}");
        nums2.RemoveAt(0);
        nums2.Insert(0, 150);
        nums2.Insert(1, 2200);
        Console.WriteLine($"List count: {nums2.Count}");
        Console.WriteLine($"List => {string.Join(", ", nums2)}");

        foreach (var number in nums2)
        {
            Console.WriteLine($"=>{number*2}");
        }
        //for (int i = 0; i < nums2.Count; i++)
        //{
        //    Console.WriteLine($"<={nums2[i]}");
        //}
    }
}

