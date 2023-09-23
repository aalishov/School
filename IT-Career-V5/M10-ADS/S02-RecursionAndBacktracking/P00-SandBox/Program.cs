using System;

namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A(10);
        }

        public static int A(int a)
        {
            if (a==0)
            {
                return 0;
            }
            Console.WriteLine(a);
            return A(--a);
        }
    }
}
