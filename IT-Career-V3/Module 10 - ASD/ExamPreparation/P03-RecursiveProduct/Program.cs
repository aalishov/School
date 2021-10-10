using System;

namespace P03_RecursiveProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(product(5,3));
        }

        static int product(int x, int y)
        {
            if (x < y)
            {
               // Console.WriteLine($"x<y, {x}<{y}");
                return product(y, x);
            }
            else if (y != 0)
            {
               // Console.WriteLine($"y!=0, x={x}, y={y}");
                return (x + product(x, y - 1));
            }
            else
            {
                //Console.WriteLine("return 0");
                return 0;
            }
        }
    }
}
