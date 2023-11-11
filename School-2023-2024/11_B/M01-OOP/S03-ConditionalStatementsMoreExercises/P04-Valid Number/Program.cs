namespace P04_Valid_Number
{
    using System;
    public class Program
    {
        public static void Main()
        {
           double num = double.Parse(Console.ReadLine());
            if (num >= 1 && num % 5== 0)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}