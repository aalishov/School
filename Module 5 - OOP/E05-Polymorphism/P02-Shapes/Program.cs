using System;
using System.Collections.Generic;

namespace P02_Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle() { Radius = 7 };
            Shape rect = new Rectangle() { Width = 8, Height = 4 };

            List<Shape> shapes = new List<Shape>() { circle, rect };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Draw());
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine(shape.CalculateArea());
            }
        }
    }
}
