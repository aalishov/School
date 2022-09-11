using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        List<int> list = arr.ToList();
        Console.WriteLine(Sum(arr));
        Console.WriteLine(Sum(list));
    }

    public static int Sum(IEnumerable<int> arr)
    {
        int sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }
        return sum;
    }
    
}

