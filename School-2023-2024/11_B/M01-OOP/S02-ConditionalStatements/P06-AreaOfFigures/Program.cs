using System;
namespace P06_AreaOfFigures
{
    public class Program
    {
        public static void Main()
        {
            string shape = Console.ReadLine();
            double s = 0;
            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                s = a * a;

            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                s = a * b;
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                s = Math.PI * r * r;
            }
            else if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                s = a * ha / 2;
            }
            Console.WriteLine($"{s:f3}");
        }
    }
}