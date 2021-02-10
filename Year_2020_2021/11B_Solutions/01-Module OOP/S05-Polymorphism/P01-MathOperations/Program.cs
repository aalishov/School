using System;

namespace P01_MathOperations
{
    public class Program
    {
        public static void Main()
        {
            MathOperation math = new MathOperation();
            Console.WriteLine(math.Add(5, 2));
            Console.WriteLine(math.Add(5.0,2.0,1.0));
            Console.WriteLine(math.Add(5m, 2m, 3m));
        }
    }
}
