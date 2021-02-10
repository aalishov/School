using System;


class Program
{
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double firstPipe = p1 * h;
        double secondPipe = p2 * h;

        double total = firstPipe + secondPipe;


        if (total > v)
        {
            double diff = total - v;
            Console.WriteLine($"For {h} hours the pool overflows with {diff} liters.");
        }
        else
        {
            int fullPercent = Percent(total, v);
            int pipe1Percent = Percent(firstPipe, total);
            int pipe2Percent = Percent(secondPipe, total);

            Console.WriteLine($"The pool is {fullPercent}% full. Pipe 1: {pipe1Percent}%. Pipe 2: {pipe2Percent}%.");
        }
    }

    static int Percent(double part, double total)
    {
        return (int)(part / total * 100.0);
    }
}

