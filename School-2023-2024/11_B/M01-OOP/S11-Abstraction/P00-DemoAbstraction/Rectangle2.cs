using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public class Rectangle2 : Shape
    {
        public Rectangle2(string color,double width, double height ) : base(color)
        {
            Width = width;
            Height = height;
        }


        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
