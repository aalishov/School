using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[20];

        nums[0] = 12;
        nums[nums.Length-1] = 54;
        Console.WriteLine(string.Join(", ", nums));
        Console.WriteLine($"Arr length: {nums.Length}");

        bool[] days = new bool[31];
        days[0] = true;
        days[days.Length - 1]=true;
        Console.WriteLine(string.Join(", ", days));
        Console.WriteLine($"Arr length: {days.Length}");

        var arr = Console.ReadLine()
             .Split(' ') //разделя по интервал
             .Select(int.Parse) //преобразува на цели числа
             .ToArray(); //масив

        var arr1 = Console.ReadLine()
             .Split(' ') //разделя по интервал
             .Select(decimal.Parse) //преобразува на цели числа
             .ToArray();
    }
}

