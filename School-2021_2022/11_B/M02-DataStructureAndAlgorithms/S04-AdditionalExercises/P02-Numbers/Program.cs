using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        IList<int> nums = Console.ReadLine()
            .Split(',')
            .Select(int.Parse)
            .ToList();
        IList<int> even = nums
            .Where(x => x % 2 == 0)
            .ToList();
        IList<int> odd = nums
            .Where(x => x % 2 != 0)
            .ToList();
        IList<int> five = nums
            .Where(x => SumDigit(x) % 10 == 5)
            .ToList();

        Console.WriteLine(string.Join(", ", even));
        Console.WriteLine(string.Join(", ", odd));
        Console.WriteLine(string.Join(", ", five));
    }
    public static int SumDigit(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += (num % 10);
            num /= 10;
        }
        return sum;
    }

}

