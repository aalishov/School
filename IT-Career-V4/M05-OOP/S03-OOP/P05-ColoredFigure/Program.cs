namespace P05_ColoredFigure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static List<ColoredFigure> coloredFigures = new List<ColoredFigure>();
        public static void Main()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter info: ");
                string[] info = Console.ReadLine().Split(' ').ToArray();

                string cmd = info[0];
                string color = info[1];
                double size = double.Parse(info[2]);

                switch (cmd)
                {
                    case nameof(Circle):
                        coloredFigures.Add(new Circle(color, size));
                        break;
                    case nameof(Square):
                        coloredFigures.Add(new Square(color, size));
                        break;
                    case nameof(Triangle):
                        coloredFigures.Add(new Triangle(color, size));
                        break;
                    default:
                        break;
                }
            }

            foreach (var figure in coloredFigures)
            {
                Console.WriteLine(figure.GetName());
                Console.WriteLine(figure.Show());
                Console.WriteLine($"Area: {figure.GetArea()}");
            }
        }
    }
}
