using System;

namespace P01_DemoRecursion
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int result = Fib(n);
            Console.WriteLine(result);
        }

        public static int Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

    }
}
