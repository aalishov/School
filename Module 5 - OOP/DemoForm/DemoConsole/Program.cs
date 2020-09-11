using System;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());


            double time2 = distance * time;
            double addedTime = (int)(distance / 15 )* 12.5;
            Console.WriteLine(addedTime);
            double totalTime = time2 + addedTime;

            if (record<totalTime)
            {
                Console.WriteLine($"No, he failed! He was {totalTime-record} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime} seconds.");
            }
        }
    }
}
