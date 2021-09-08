using System;

class Program
{
    static void Main()
    {
        int f = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int t = int.Parse(Console.ReadLine());

        int sum = f + s + t;

        int minutes = sum / 60;
        int seconds = sum % 60;

        if (seconds>9)
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
    }
}

