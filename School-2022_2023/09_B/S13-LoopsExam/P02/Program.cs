using System;

namespace P02
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0; int p2 = 0; int p3 = 0;
            for (int i = 0; i < n; i++)
            {
             int num = int.Parse(Console.ReadLine());
                if (num%2 == 0)
                {
                    p1++;
                }
                if (num%3==0)
                {
                    p2++;
                }
                if (num % 4 == 0) 
                {
                    p3++;
                }
                
            }
            Console.WriteLine($"{p1/(double)n*100.0:f2}%");
            Console.WriteLine($"{p2 / (double)n * 100.0:f2}%");
            Console.WriteLine($"{p3 / (double)n * 100.0:f2}%");
        }
    }
}
