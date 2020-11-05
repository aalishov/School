using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        Console.WriteLine($"Even numbers => {string.Join(" | ", numbers.Where(x => x % 2 == 0))}");

        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    if (numbers[i]%2==0)
        //    {
        //        Console.WriteLine($"Even number on index[{i}] = {numbers[i]}");
        //    }
        //}
    }
}

