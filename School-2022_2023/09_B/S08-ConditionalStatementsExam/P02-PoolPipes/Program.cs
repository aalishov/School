using System;
using System.Diagnostics.SymbolStore;

public class Program
{
    public static void Main()
    {
        int volume = int.Parse(Console.ReadLine());
        int firstPipe = int.Parse(Console.ReadLine());
        int secondPipe = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double firstPipeVolume = firstPipe * hours;
        double secondPipeVolume = secondPipe * hours;
        double totalPipes = firstPipeVolume + secondPipeVolume;

        if (totalPipes > volume)
        {
            double overflow = totalPipes - volume;
            Console.WriteLine($"For {hours} hours the pool overflows with {overflow} liters.");
        }
        else
        {
            int poolPercent = (int)(totalPipes / volume * 100);
            int firstPipePercent = (int)(firstPipeVolume / totalPipes * 100);
            int secondPipePercent = (int)(secondPipeVolume / totalPipes * 100);
            Console.WriteLine($"The pool is {poolPercent}% full. Pipe 1: {firstPipePercent}%. Pipe 2: {secondPipePercent}%.");
        }

    }
}

