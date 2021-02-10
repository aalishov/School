namespace P03_Figures
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            Shape rectangle = new Rectangle(3,7);
            Shape cirlce = new Circle(5);

            shapes.Add(rectangle);
            shapes.Add(cirlce);

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} area {shape.CalculateArea()}");
                Console.WriteLine($"{shape.GetType().Name} perimeter {shape.CalculatePerimeter()}");
                Console.WriteLine(shape.Draw());

                //Лоша практика
                //Всеки път, когато усетиш, че пишеш код от типа „ако обекта е от тип T1, то направи нещо, но ако е от тип T2, то направи друго нещо“, си забий шамар.

                //if (shape is Rectangle)
                //{
                //    Console.WriteLine($"Rectangle area {shape.CalculateArea()}");
                //    Console.WriteLine($"Rectangle perimeter {shape.CalculatePerimeter()}");
                //}
                //else if (shape is Circle)
                //{
                //    Console.WriteLine($"Circle area {shape.CalculateArea()}");
                //    Console.WriteLine($"Cirlce perimeter {shape.CalculatePerimeter()}");
                //}
            }

        }
    }
}
