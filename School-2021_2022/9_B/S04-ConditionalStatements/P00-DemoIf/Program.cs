using System;

namespace P00_DemoIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            if (a % 2 == 0)
            {
                Console.WriteLine("even");
                int sum = 10;
                sum += a;
                Console.WriteLine(sum);
            }
            else
            {
                int sum = 10;
                Console.WriteLine("odd");
            }

            if (a>0)
            {
                Console.WriteLine("positive");
            }
            else if (a<0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }

        }
        
    }
}
