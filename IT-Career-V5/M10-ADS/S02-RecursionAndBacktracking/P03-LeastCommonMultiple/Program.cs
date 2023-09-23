using System;

namespace P03_LeastCommonMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a [Sample: 6]=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b [Sample: 15]=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Least Common Multiple [Sample: 30] = {0}", Lcm(a, b)); // gcd = 7
        }

        // Метод за намиране на най-малко общо кратно
        private static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }

        // Рекурсивен метод за намиране на най-голям общ делител
        private static int Gcd(int a, int b)
        {
            if (a == b) return a;
            if (a > b) return Gcd(a - b, b);
            else return Gcd(a, b - a);
        }
    }
}
