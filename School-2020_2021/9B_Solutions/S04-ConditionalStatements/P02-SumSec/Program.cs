using System;

public class Program
{
    public static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int totalTime = first + second + third;
        // 120/60=2
        // 136/60=2 => 136%60=16
        int minutes = totalTime / 60;
        int seconds = totalTime % 60;

        if (seconds<10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}

