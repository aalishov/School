using System;


class Program
{
    static void Main(string[] args)
    {
        Run();
    }
    public static void Run()
    {
        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (input=="end")
            {
                break;
            }
            int number = int.Parse(input);
            PrintSign(number);
        }
    }

    public static void PrintSign(int number)
    {
        if (number>0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number<0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else
        {
            Console.WriteLine("The number 0 is zero.");
        }
    }
    public static void PrintSign(double number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else
        {
            Console.WriteLine("The number 0 is zero.");
        }
    }
    public static void PrintSign(decimal number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else
        {
            Console.WriteLine("The number 0 is zero.");
        }
    }
}

