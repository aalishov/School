using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedDictionary<int, string> colors = new SortedDictionary<int, string>();
        colors.Add(1, "Red");
        colors.Add(5, "Blue");
        colors.Add(3, "White");
        colors.Add(2, "Black");
        colors.Add(0, "Orange");
        foreach (var item in colors)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }

        Console.WriteLine(new string('*',20));

        foreach (var item in colors.OrderBy(x=>x.Value))
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}

