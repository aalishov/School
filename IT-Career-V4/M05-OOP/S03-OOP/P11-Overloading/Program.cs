using System;

namespace P11_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation math = new MathOperation();

            Console.WriteLine(math.Sum(15,10));
            Console.WriteLine(math.Sum(14.3,12.8));
            Console.WriteLine(math.Sum(14.3, 12));
            Console.WriteLine(math.Sum('a','b'));
        }
    }
}
