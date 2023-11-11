using System;
namespace P02_JuiceProducing
{
    public class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sum = a * b;
            double juice = sum * 0.4/2.3;
            if (juice>c)
            {
                Console.WriteLine($"Great job! Total boxes {Math.Floor(juice)}.");
            }
            else
            {
                Console.WriteLine($"Not enough juice with {Math.Floor(c-juice)} boxes less.");
            }

        }
    }
}