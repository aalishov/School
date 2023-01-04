using System;

public class Program
{
    public static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());

        if (minute + 15 >= 60)
        {
            minute = (minute + 15) - 60;
            hour++;
            if (hour > 23) { hour = 0; }
        }
        else { minute += 15; } // minute=minute+15; 

        if (minute < 10)
        {
            Console.WriteLine($"{hour}:0{minute}");
        }
        else
        {
            Console.WriteLine($"{hour}:{minute}");
        }
    }
}

