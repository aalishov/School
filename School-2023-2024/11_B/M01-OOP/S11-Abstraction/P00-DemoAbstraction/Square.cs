using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public class Square : ICalculatableArea, IPrintable
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; private set; }

        public double Area()
        {
            return Side * Side;
        }

        public string Print()
        {
            return $"I'm {nameof(Square)}, my area is: {Area()}";
        }
    }
}
