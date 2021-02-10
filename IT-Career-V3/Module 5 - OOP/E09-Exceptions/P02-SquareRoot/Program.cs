using System;
using System.Reflection.Metadata;

namespace P02_SquareRoot
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string s = Console.ReadLine();
            try
            {
                int num = int.Parse(s);
                try
                {
                    if (num<=0)
                    {
                        throw new ArgumentException("Number must be positive!");
                    }
                    double result = Math.Sqrt(num);
                    Console.WriteLine(result);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            catch (FormatException fe)
            {

                Console.WriteLine(fe.Message);
            }
            Console.WriteLine("Good bye!");
        }
    }
}
