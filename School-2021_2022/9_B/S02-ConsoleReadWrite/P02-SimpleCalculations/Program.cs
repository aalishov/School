using System;

namespace P02_SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeteres = inches * 2.54;
            Console.WriteLine($"Centimeters =  {centimeteres}");
        }
    }
}
