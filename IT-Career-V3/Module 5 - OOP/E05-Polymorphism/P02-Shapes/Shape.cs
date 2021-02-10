using System;
using System.Collections.Generic;
using System.Text;

namespace P02_Shapes
{
    public abstract class Shape
    {
        public abstract string CalculatePerimeter();
        public abstract string CalculateArea();

        public virtual string Draw()
        {
            return "Drawing shape:"+Environment.NewLine;
        }
    }
}
