using System;
public class Program
{
    private const int Norma = 30000;
    private const int PlayTimeFreeDays = 127;
    private const int PlayTimeWorkDays = 63;
    private const int MinutesInOneHour = 60;
    public static void Main()
    {
        int freeDays = int.Parse(Console.ReadLine());
        int workDays = 365 - freeDays;

        int playTime = freeDays * PlayTimeFreeDays + workDays * PlayTimeWorkDays;
        int diff = Math.Abs(Norma - playTime);

        int hh = diff / MinutesInOneHour;
        int mm = diff % MinutesInOneHour;

        if (playTime > Norma)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hh} hours and {mm} minutes more for play");
        }
        else
        {
            Console.WriteLine($"Tom sleeps well");
            Console.WriteLine($"{hh} hours and {mm} minutes less for play");
        }
    }
}

