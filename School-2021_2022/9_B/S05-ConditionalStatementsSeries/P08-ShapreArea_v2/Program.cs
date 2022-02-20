using System;

namespace P08_ShapreArea_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            switch (shape)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    area = a * a;
                    break;
                case "rectangle":
                    double w = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    area = w * h;
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * r * r;
                    break;
                case "triangle":
                    double c = double.Parse(Console.ReadLine());
                    double hc = double.Parse(Console.ReadLine());
                    area = c * hc / 2;
                    break;
                default:
                    break;
            }
            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
