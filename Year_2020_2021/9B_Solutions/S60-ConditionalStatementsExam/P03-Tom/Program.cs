using System;

class Program
{
    const int YearDays = 365;
    const int PlayMinutesFreeDays = 127;
    const int PlayMinutesWorkDays = 63;
    const int TomSleepMinutes = 30000;
    static void Main()
    {
        int freeDays = int.Parse(Console.ReadLine());
        int workDays = YearDays - freeDays;

        int playMinutes = freeDays * PlayMinutesFreeDays + workDays * PlayMinutesWorkDays;

        bool isSleepWell = TomSleepMinutes > playMinutes;

        int sleepMinutes = Math.Abs(TomSleepMinutes - playMinutes);
        int hours = sleepMinutes / 60;
        int minutes = sleepMinutes % 60;

        if (isSleepWell)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
        else
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
    }
}

