using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public class Triangle : ICalculatableArea, IPrintable
    {
        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public double Side { get; private set; }
        public double Height { get; private set; }
        public double Area()
        {
            return (Side* Height)/2;
        }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
