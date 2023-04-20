using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int roofCount = (int)Math.Ceiling(n / 2.0);

        int starsCount = 0;

        if (n % 2 == 0) { starsCount = 2; }
        else { starsCount = 1; }

        for (int i = 0; i < roofCount; i++)
        {
            Console.Write(new string('-',n/2-i));
            Console.Write(new string('*', starsCount)); ;
            Console.Write(new string('-', n / 2 - i));
            starsCount += 2;
            Console.WriteLine();
        }
    }
}

