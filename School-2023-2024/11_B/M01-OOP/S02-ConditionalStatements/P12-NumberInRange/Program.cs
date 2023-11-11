using System;
namespace P12_NumberInRange
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= -100 && number <= 100 && number != 0)
            { Console.WriteLine("Yes"); }
            else
            { Console.WriteLine("No"); }
        }
    }
}