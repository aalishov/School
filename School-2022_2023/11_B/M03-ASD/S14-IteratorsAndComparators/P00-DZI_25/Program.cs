using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());

        Dictionary<int,int> counter= new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (counter.ContainsKey(num))
            {
                counter[num]++;
            }
            else
            {
                counter.Add(num, 1);
            }
        }

        foreach (var num in counter)
        {
            Console.WriteLine($"число: {num.Key}, брой: {num.Value}");
        }
    }
}
