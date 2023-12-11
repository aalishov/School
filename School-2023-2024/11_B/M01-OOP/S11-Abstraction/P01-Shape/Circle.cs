using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P01_Shape
{
    public class Circle:IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get;private set; }
        

        public void Draw()
        {
            double rin = this.Radius - 0.4;
            double rout = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rout; x +=0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rin * rin && value <= rout * rout)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
