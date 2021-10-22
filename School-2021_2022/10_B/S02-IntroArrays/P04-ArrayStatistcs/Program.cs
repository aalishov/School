using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine() //"1 2 3 -5"
            .Split(' ')// "1" "2" "3" "-5"
            .Select(int.Parse)// 1 2 3 -5
            .ToArray(); //numbers []= {1,2,3,-5}

        int max = int.MinValue;//
        int min = int.MaxValue;
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i]) { max = numbers[i]; }
            if (min > numbers[i]) { min = numbers[i]; }
            sum += numbers[i];
        }
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {sum / (double)numbers.Length}");
    }
}

