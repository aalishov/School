using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        TimeSpan firstPlayer;
        TimeSpan secondPlayer;

        Console.Write("Are you ready? Press Enter to start!");
        Console.ReadLine();
        Stopwatch stopwatch = new Stopwatch();
        Random random = new Random();

        int num = random.Next(1, 50);
        stopwatch.Start();
        while (true)
        {
            Console.Write("Enter num: ");
            int myNum = int.Parse(Console.ReadLine());
            if (myNum > num)
            {
                Console.WriteLine("Down");
            }
            else if(myNum<num)
            {
                Console.WriteLine("Up");
            }
            if (myNum == num)
            {
                stopwatch.Stop();
                firstPlayer = stopwatch.Elapsed;
                Console.WriteLine($"Excellent! Magic number is {num}");
                break;
            }
            Console.WriteLine("Try again!");
        }


        Console.Write("Are you ready? Press Enter to start!");
        Console.ReadLine();
        Stopwatch stopwatch2 = new Stopwatch();
        Random random2 = new Random();
        int num2 = random.Next(1, 50);
        stopwatch2.Start();
        while (true)
        {
            Console.Write("Enter num: ");
            int myNum = int.Parse(Console.ReadLine());
            if (myNum > num2)
            {
                Console.WriteLine("Down");
            }
            else if (myNum < num2)
            {
                Console.WriteLine("Up");
            }
            if (myNum == num2)
            {
                stopwatch2.Stop();
                secondPlayer = stopwatch2.Elapsed;
                Console.WriteLine($"Excellent! Magic number is {num2}");
                break;
            }
            Console.WriteLine("Try again!");
        }

        Console.WriteLine($"First player time: {firstPlayer}");
        Console.WriteLine($"Second player time: {secondPlayer}");

        if (firstPlayer<secondPlayer)
        {
            Console.WriteLine($"First player wins!");
        }
        else if(firstPlayer > secondPlayer)
        {
            Console.WriteLine($"Second player wins!");
        }
        else
        {
            Console.WriteLine("No winner!");
        }
    }
}

