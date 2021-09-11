using System;

namespace P06_IFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable circle = new Circle(8);
            IDrawable rectangle = new Rectangle(10, 5);
            Console.WriteLine(rectangle.Draw());
        }
    }
}
