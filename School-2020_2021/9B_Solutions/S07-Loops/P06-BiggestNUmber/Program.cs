using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter count: ");
        int n = int.Parse(Console.ReadLine());

        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            //Вариант 1
            //if (number>max)
            //{
            //    max = number;
            //}

            //Вариант 2
            //max = number > max ? number : max;

            //Вариант 3
            max = Math.Max(max, number);
        }
        Console.WriteLine($"Max: {max}");
    }
}

