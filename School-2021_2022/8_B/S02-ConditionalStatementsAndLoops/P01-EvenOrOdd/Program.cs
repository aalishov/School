using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        bool isEven = n % 2 == 0;
        if (isEven)
        {
            Console.WriteLine($"Number {n} is even!");
        }
        else
        {
            Console.WriteLine($"Number {n} is odd!");
        }
    }
}

