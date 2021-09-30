using System;

namespace P04_SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.WriteLine($"Square = {area}");
        }
    }
}
