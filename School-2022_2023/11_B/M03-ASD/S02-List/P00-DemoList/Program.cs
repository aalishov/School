using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        list.Insert(1,5);

        Console.WriteLine(string.Join(" | ", list));

    }
}

