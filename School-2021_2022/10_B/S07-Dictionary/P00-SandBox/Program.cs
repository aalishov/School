
using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Dictionary<string,int[]> d = new Dictionary<string, int[]>();
        d.Add("ivan", new int[] { 3,4,6});
        d.Add("gosho", new int[] { 5, 4, 6 });
        //Console.WriteLine(string.Join(" ",d));
        foreach (var item in d)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {string.Join(", ", item.Value)}");
        }
    }
}

