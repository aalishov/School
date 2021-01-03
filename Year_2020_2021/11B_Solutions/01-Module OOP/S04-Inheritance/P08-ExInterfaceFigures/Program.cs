using System;
using System.Collections.Generic;

namespace P08_ExInterfaceFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawables = new List<IDrawable>();

            Cirlce cirlce = new Cirlce(5);
            Cirlce cirlce1 = new Cirlce(9);
            Rectangle rectangle = new Rectangle(10, 5);
            Rectangle rectangle1 = new Rectangle(7, 5);

            drawables.Add(cirlce);
            drawables.Add(cirlce1);
            drawables.Add(rectangle);
            drawables.Add(rectangle1);

            foreach (var figure in drawables)
            {
                Console.WriteLine(figure.Print());
            }
        }
    }
}
