using System;

class Program
{
    static void Main()
    {
        int volume = int.Parse(Console.ReadLine());
        int pipeOne = int.Parse(Console.ReadLine());
        int pipeTwo = int.Parse(Console.ReadLine());
        double hour = double.Parse(Console.ReadLine());

        double pipeOneWater = pipeOne * hour;
        double pipeTwoWater = pipeTwo * hour;
        double poolActualVolume = pipeOneWater + pipeTwoWater;

        bool isOverflows = poolActualVolume > volume;

        if (isOverflows)
        {
            Console.WriteLine($"For {hour} hours the pool overflows with {poolActualVolume-volume} liters.");
        }
        else
        {
            int fullInPercent = (int)(poolActualVolume / volume * 100);
            int pipeOneInPercent = (int)(pipeOneWater / poolActualVolume * 100);
            int pipeTwoInPercent = (int)(pipeTwoWater / poolActualVolume * 100);
            Console.WriteLine($"The pool is {fullInPercent}% full. Pipe 1: {pipeOneInPercent}%. Pipe 2: {pipeTwoInPercent}%.");
        }
    }
}

