using System;
using System.Collections.Generic;
using System.Text;

namespace P02_Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override string CalculateArea()
        {
            return $"Circle area: {Math.PI * Radius * Radius}";
        }

        public override string CalculatePerimeter()
        {
            return $"Circle perimeter: {2*Math.PI * Radius}";
        }
        public override string Draw()
        {
            StringBuilder sb = new StringBuilder(base.Draw());

            double r_in = this.Radius - 0.4;
            double r_out = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                        sb.Append("*");
                    else
                        sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString().TrimEnd();
        }
    }
}
