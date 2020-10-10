using System;

namespace P01_v2_DemoOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 9;
            //int p = 9;
            ////n++;
            ////++p;
            //Console.WriteLine(n++);
            //Console.WriteLine(++p);

            int n = 12;
            int d = 3;
            Console.WriteLine(n/d);
            Console.WriteLine(++n%d--);
        }
    }
}
