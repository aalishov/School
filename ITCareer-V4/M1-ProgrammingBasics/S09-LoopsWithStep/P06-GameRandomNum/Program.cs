using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        Random random = new Random();
        int num = random.Next(1, 200);
        stopwatch.Start();
        while (true)
        {
            Console.Write("Enter num: ");
            int myNum = int.Parse(Console.ReadLine());
            if (myNum>num)
            {
                Console.WriteLine("Down");
            }
            else
            {
                Console.WriteLine("Up");
            }
            if (myNum==num)
            {
                Console.WriteLine($"Excellent! Magic number is {num}");
                Console.WriteLine($"Your time: {stopwatch.Elapsed}");
                break;
            }
            Console.WriteLine("Try again!");
        }
    }
}

