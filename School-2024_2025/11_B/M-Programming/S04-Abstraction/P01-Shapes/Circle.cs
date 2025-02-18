using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Shapes
{
    internal class Circle : IDrawable
    {

        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public void Draw()
        {
            double radiusIn = this.radius - 0.4;
            double radiusOut = this.radius + 0.4;

            for (double y = this.radius; y >= -this.radius; y--)
            {
                for (double x = -this.radius; x < radiusOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }

                Console.WriteLine();
            }

        }
    }
}
