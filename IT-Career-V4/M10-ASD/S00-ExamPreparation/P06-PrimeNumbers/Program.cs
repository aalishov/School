using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int i = 0;
        while (counter!=n)
        {
            i++;
            if (IsPrime(i))
            {
                counter++;
                Console.WriteLine(i);
            }
        }
    }
    public static bool IsPrime(long number)
    {
        if (number <= 1)
            return false;
        else if (number % 2 == 0)
            return number == 2;

        long N = (long)(Math.Sqrt(number) + 0.5);

        for (int i = 3; i <= N; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}
