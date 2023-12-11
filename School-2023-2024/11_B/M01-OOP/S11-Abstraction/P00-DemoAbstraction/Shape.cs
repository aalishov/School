using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_DemoAbstraction
{
    public abstract class Shape
    {
        protected Shape(string color)
        {
            Color = color;
        }

        public string Color { get; set; }
        public abstract double CalculateArea();

        public override string ToString()
        {
            return $"{GetType().Name}, my color is {Color} area: {CalculateArea()}";
        }
    }
}
