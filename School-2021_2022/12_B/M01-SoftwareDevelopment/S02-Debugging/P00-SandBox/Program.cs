using System;
using System.Numerics;

namespace P00_SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = 5000;
            BigInteger product = 1;
            for (int i = 1; i <= result; i++)
            {
                product = BigInteger.Multiply(product, i);
            }
            Console.WriteLine(product);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
