using System;

class Program
{
    static void Main()
    {
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num<=199)
            {
                p1++;
            }
            else if (num>=200&&num<=399)
            {
                p2++;
            }
            else if (num>=400&&num<=599)
            {
                p3++;
            }
            else if (num>=600&&num<=799)
            {
                p4++;
            }
            else
            {
                p5++;
            }
        }
        Console.WriteLine(Percent(p1,n));
        Console.WriteLine(Percent(p2, n));
        Console.WriteLine(Percent(p3, n));
        Console.WriteLine(Percent(p4, n));
        Console.WriteLine(Percent(p5, n));
    }

    static string Percent(int part, int total)
    {
        double result = part / (double)total * 100.0;

        return $"{result:f2}%";
    }
}

