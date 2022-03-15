using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] input = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        Stack<int> box = new Stack<int>(input);
        int rackCapcity = int.Parse(Console.ReadLine());
        int racksCount = 1;
        int clothesSum = 0;
        while (box.Count > 0)
        {
            if ((clothesSum + box.Peek()) > rackCapcity)
            {
                racksCount++;
                clothesSum = 0;
            }
            clothesSum += box.Pop();
        }
        Console.WriteLine(racksCount);
        //Console.WriteLine(string.Join(", ", box));
    }
}

