using System;

namespace P05_Lotary
{
    class Program
    {
        static void Main()
        {
            decimal sum = 0;
            decimal profit = 0;

            for (int i = 0; i < 5; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int money = int.Parse(Console.ReadLine());
                profit += money;
                Console.WriteLine("Try again!");
            }

            sum = profit *0.5m;
            Console.WriteLine($"You win {sum}!");
        }
    }
}
