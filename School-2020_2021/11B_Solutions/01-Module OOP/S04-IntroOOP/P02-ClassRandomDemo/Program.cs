using System;

namespace P02_ClassRandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Random r2 = new Random();

            Console.WriteLine(random.Next(5,20));
            Console.WriteLine(r2.Next(100,1000));
        }
    }
}
