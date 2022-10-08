using System;

internal class Program
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        if (minutes >= 45)
        {
            hour += 1;
            if (hour == 24)
            { hour = 0; }
            int leftMinutes = 60 - minutes;
            minutes = 15 - leftMinutes;
        }
        else { minutes += 15; }
        if (minutes < 10)
        { Console.WriteLine($"{hour}:0{minutes}"); }
        else
        {
            Console.WriteLine($"{hour}:{minutes}");
        }
    }
}
