using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> evenNumbers = new List<int>();

        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Queue<int> nums = new Queue<int>(arr);

        while (nums.Any())
        {
            int num = nums.Dequeue();
            if (num % 2 == 0)
            {
                evenNumbers.Add(num);
            }
        }

        Console.WriteLine(string.Join(", ", evenNumbers));

        // Вариант 2 за решение на задачата
        //Console.WriteLine(string.Join(", ",
        //    Console.ReadLine()
        //    .Split(' ')
        //    .Select(int.Parse)
        //    .Where(x => x % 2 == 0)
        //    .ToList()));
    }
}

