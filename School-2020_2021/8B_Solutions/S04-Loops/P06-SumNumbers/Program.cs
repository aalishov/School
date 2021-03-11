using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter numbers count: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}

