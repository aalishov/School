using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = (int)Math.Ceiling(Math.Sqrt(n));

        bool isPrime = true;

        for (int i = 2; i <= count; i++)
        {
            if (n / i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime || n == 2)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}

