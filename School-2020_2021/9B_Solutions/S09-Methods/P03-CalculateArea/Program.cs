using System;

namespace P03_CalculateArea
{
    class Program
    {
        static void Main()
        {

            TriangleArea(ReadData("a"), ReadData("hA"));
            RecatngleArea(5, 6);
            RecatngleArea(ReadData("a"), ReadData("b"));
            CircleArea(ReadData("circle radius"));
            CircleArea(ReadData("r"));
        }
        public static void CircleArea(double r)
        {
            Console.WriteLine($"Cirlce area = {Math.PI * Math.Pow(r, 2)}");
        }

        public static void TriangleArea(double a, double hA)
        {
            Console.WriteLine($"Triangle area = {(a * hA) / 2}");
        }

        public static void RecatngleArea(double a, double b)
        {
            Console.WriteLine($"Rectangle area = {a * b}");
        }

        public static double ReadData(string type = "")
        {
            Console.Write($"Enter {type}: ");
            return double.Parse(Console.ReadLine());
        }

    }
}
