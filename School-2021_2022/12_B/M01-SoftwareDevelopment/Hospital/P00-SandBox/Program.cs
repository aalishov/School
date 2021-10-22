using System;

namespace P00_SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSumWithInteger(10, 15);
            TestSumWithDouble(10.2, 15.3);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static void TestSumWithInteger(int a, int b)
        {
            if (Sum(a,b)==a+b)
            {
                Console.WriteLine($"Work {nameof(TestSumWithInteger)}");
            }
            else
            {
                Console.WriteLine($"Not Work {nameof(TestSumWithInteger)}");
            }
        }
        static void TestSumWithDouble(double a, double b)
        {
            if (Sum(a, b) == a + b)
            {
                Console.WriteLine($"Work {nameof(TestSumWithDouble)}");
            }
            else
            {
                Console.WriteLine($"Not Work {nameof(TestSumWithDouble)}");
            }
        }
    }
}
