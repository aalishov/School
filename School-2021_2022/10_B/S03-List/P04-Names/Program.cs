using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = Console.ReadLine()
            .Split(", ")
            .ToList();
        foreach (var name in names)
        {
            List<string> reverseName = name
                .Split(' ')
                .ToList();
            reverseName.Reverse();
            Console.WriteLine(string.Join(" ",reverseName));
        }

    }
}

