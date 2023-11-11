using System;

namespace P16___Account_Balance
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double sum = default;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }
                double num = double.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += num;
                Console.WriteLine($"Increase: {num:f2}");
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
