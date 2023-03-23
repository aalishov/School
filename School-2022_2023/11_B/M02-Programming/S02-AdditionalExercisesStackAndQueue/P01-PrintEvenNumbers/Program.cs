using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] evens = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Queue<int> q = new Queue<int>(evens);

        string result = string.Empty;

        while (q.Count > 0)
        {
            int element = q.Dequeue();
            if (element % 2 == 0)
            {
                result+=$"{element}, ";
            }
        }
        Console.WriteLine(result);
        Console.WriteLine(result.Substring(0,result.Length-2));
    }
}

