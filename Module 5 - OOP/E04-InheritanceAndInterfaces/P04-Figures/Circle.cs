using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Figures
{
    public class Circle : IDrawable
    {
        public int Radius { get; set; }
        public void Draw()
        {
            double r_in = this.Radius - 0.4;
            double r_out = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                        Console.Write("*");
                    else
                        Console.Write(" ");                    
                }
                Console.WriteLine();
            }

        }
    }
}
