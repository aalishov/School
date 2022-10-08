using System;

public class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());
        double studio = 0; double apartament = 0;
        if (month == "May" || month == "October")
        {
            studio += 50;
            apartament += 65;
            if (nights > 14) { studio *= 0.7; }
            else if (nights > 7) { studio *= 0.95; }
        }
        else if (month == "June" || month == "September")
        {
            studio += 75.20;
            apartament += 68.7;
            if (nights > 14) { studio *= 0.8; }
        }
        else if (month == "August" || month == "July")
        {
            studio += 76;
            apartament += 77;
        }
        if (nights > 14) { apartament *= 0.9; }
        double totalApartament = nights * apartament;
        double totalStudio = nights * studio;
        Console.WriteLine($"Apartment: {totalApartament:f2} lv.");
        Console.WriteLine($"Studio: {totalStudio:f2} lv.");
    }
}

