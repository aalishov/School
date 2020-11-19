using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> numbers = Console.ReadLine()
            .Split(' ')
            .ToList();

        int sum = 0;

        foreach (var num in numbers)
        {
            sum+=int.Parse(string.Join("", num.ToCharArray().Reverse()));
        }

        Console.WriteLine(sum);
    }
}

