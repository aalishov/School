using System;

namespace Operations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(5,2));
            Console.WriteLine(mo.Add(5.2,1.1,2.2));
            Console.WriteLine(mo.Add(1m,2m,3m));
        }
    }
}
