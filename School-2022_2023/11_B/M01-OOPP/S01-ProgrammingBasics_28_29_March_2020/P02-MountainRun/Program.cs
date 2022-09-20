using System;

public class Program
{
    static void Main()
    {
        double record = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double timeForAMeter = double.Parse(Console.ReadLine());

        double secs= distance * timeForAMeter;
        double slowdown = Math.Floor(distance / 50) * 30;
        double totalTime=secs + slowdown;

        if (record>totalTime)
        {
            Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
        }
        else
        {
            double neededTime = totalTime - record;
            Console.WriteLine($"No! He was {neededTime:f2} seconds slower.");
        }
    }
}

