﻿namespace P06_IFigure
{
    using System.Text;
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }
        public string Draw()
        {
            StringBuilder sb = new StringBuilder();
            double r_in = this.Radius - 0.4;
            double r_out = this.Radius + 0.4;

            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value > r_in * r_in & value <= r_out * r_out)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString().TrimEnd();
        }
    }
}
