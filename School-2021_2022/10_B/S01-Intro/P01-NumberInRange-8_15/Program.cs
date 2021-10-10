using System;

namespace P01_NumberInRange_8_15
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string line = Console.ReadLine();
            bool isNumber = double.TryParse("15", out _);
            if (isNumber)
            {
                double number = double.Parse(line);
                if (number > -8 && number <= 15)
                {
                    Console.WriteLine("Number is in range (-8;15]");
                }
                else
                {
                    Console.WriteLine("Number is not in range (-8;15]");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
