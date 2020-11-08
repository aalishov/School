using System;


class Program
{
    static void Main()
    {
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                p1++;
            }
            if (num % 3 == 0)
            {
                p2++;
            }
            if (num % 4 == 0)
            {
                p3++;
            }
        }
        Console.WriteLine(Percent(p1, n));
        Console.WriteLine(Percent(p2, n));
        Console.WriteLine(Percent(p3, n));
    }
    static string Percent(int part, int total)
    {
        double result = part / (double)total * 100.0;

        return $"{result:f2}%";
    }
}

