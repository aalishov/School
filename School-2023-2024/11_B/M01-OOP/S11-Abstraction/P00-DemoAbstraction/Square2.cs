using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public class Square2 : Shape
    {
       
        public Square2(string color, double side) : base(color)
        {
            Side = side;
        }

        public double Side { get; private set; }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
}
