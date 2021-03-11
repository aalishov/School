using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<int> nums = new List<int>();
    static void Main()
    {
        //Решение а)
        PositiveAverage();

        //Решение б)
        SumNegativeAngGreatersThen300Numbers();

        //Решение в)
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        double result = RandomAverage(Math.Abs(c - b)) - RandomAverage(c + a);
        Console.WriteLine($"RandomAverage (|{c}-{b}|) - RandomAverage ({c}+{a}) = {result}");
    }
    //Решение в)
    //Да се създаде метод RandomAverage(k), който генерира k на брой случайни цели 
    //числа и като резултат връща средноаритметичното на тези от тях, които са в интервала [10, 100].
    private static double RandomAverage(int k)
    {
        Random random = new Random();

        int[] numbers = new int[k];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-1000, 1000);
        }
        if (numbers.Any(x => x >= 10 && x <= 100))
        {
            return numbers.Where(x => x >= 10 && x <= 100).Average();
        }
        return 0;
    }

    //Решение б)
    private static void SumNegativeAngGreatersThen300Numbers()
    {
        int[] nums = new int[7];
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Enter element [{i}]: ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Sum: {nums.Where(x => x < 0 || x > 300).Sum()}");
    }

    //Решение а)
    private static void PositiveAverage()
    {
        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out _))
            {
                int num = int.Parse(input);
                if (num == 0)
                {
                    break;
                }
                nums.Add(num);
            }
            else
            {
                Console.WriteLine("You enter NaN (not a number). Try again!");
            }
        }
        Console.WriteLine($"Average: {nums.Where(x => x > 0).Average()}");
    }
}

