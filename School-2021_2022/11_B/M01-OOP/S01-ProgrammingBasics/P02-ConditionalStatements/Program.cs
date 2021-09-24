using System;

namespace P02_ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = 5 != 5;
            if (isTrue)
            {
                Console.WriteLine("Differenet");
            }
            else
            {
                Console.WriteLine("Same");
            }

            int number = 2;
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("NaN");
                    break;
            }
        }
    }
}
