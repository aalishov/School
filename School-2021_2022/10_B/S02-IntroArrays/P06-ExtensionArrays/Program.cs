using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine($"Sum: {nums.Sum()}");
        Console.WriteLine($"Max: {nums.Max()}");
        Console.WriteLine($"Min: {nums.Min()}");
        Console.WriteLine($"Average: {nums.Average()}");

        // Array.Sort(nums); // Сортира във възходящ
        // Array.Reverse(nums); //Обръща масива

        nums = nums.OrderBy(x => x).ToArray();
        Console.WriteLine($"Sorted ASC: {string.Join(", ", nums)}");

        nums = nums.OrderByDescending(x => x).ToArray();
        Console.WriteLine($"Sorted DESC: {string.Join(", ", nums)}");

        int[] positive = nums.Where(x => x > 0).ToArray();
        Console.WriteLine($"Positive: {string.Join(", ", positive)}");

        int[] even = nums.Where(x => x % 2 == 0).ToArray();
        Console.WriteLine($"Even: {string.Join(", ", even)}");

        Console.WriteLine(string.Join(" | ", nums));
    }
}

