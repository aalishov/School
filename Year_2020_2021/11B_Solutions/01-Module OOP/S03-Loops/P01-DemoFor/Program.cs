using System;
using System.Text;

namespace P01_DemoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("Print line");
            //    Console.WriteLine("Print line 2");
            //    Console.WriteLine($"Value i: {i}");
            //    if (i%2==0)
            //    {
            //        Console.WriteLine("Even i");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd i");
            //    }
            //}

            //for (int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine($"i={i}");
            //}

            for (int i = 'a'; i < 1000; i++)
            {
                Console.WriteLine($"{i} => {(char)i}");
            }
        }
    }
}
