using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        Console.WriteLine($"=> {string.Join(", ",numbers)}");
        Console.WriteLine($"ASC => {string.Join(", ", numbers.OrderBy(x=>x))}");
        Console.WriteLine($"DESC => {string.Join(", ", numbers.OrderByDescending(x => x))}");
        Console.WriteLine($"Sum => {numbers.Sum()}");
        Console.WriteLine($"Average => {numbers.Average()}");
        Console.WriteLine($"Max => {numbers.Max()}");
        Console.WriteLine($"Min => {numbers.Min()}");
    }
}
