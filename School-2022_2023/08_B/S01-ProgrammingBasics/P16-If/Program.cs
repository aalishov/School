using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        bool isEven = num % 2 == 0;

        if (isEven)
        {
            Console.WriteLine("Number is even!");
        }
        else
        {
            Console.WriteLine("Number is odd!");
        }
    }
}

