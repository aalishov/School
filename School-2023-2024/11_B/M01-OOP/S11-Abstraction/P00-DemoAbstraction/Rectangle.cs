using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public class Rectangle : ICalculatableArea,IPrintable
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; private set; }
        public double Height { get; private set; }

        public double Area()
        {
            return Width * Height;
        }

        public string Print()
        {
            return $"Rectangle area: {Area()}";
        }
    }
}
