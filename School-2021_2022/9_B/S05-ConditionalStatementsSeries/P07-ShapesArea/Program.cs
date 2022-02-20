using System;

namespace P07_ShapesArea
{
    class Program
    {
        static void Main()
        {
            string shape = Console.ReadLine().ToLower();
            double area = 0;
            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;

            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (shape== "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (shape=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
