using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
       
        while (true)
        {
            stopwatch.Start();
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Enter even number: {n}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid number!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Random random = new Random();
            //Console.WriteLine($"=>{random.Next(1,15)}");
            //Thread.Sleep(5000);
            
        }
        Console.WriteLine(stopwatch.Elapsed);
    }
}

