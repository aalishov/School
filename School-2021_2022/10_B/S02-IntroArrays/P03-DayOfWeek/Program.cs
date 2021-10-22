using System;

namespace P03_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sunday", "Monday" };
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number<=7)
            {
                Console.WriteLine(days[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
