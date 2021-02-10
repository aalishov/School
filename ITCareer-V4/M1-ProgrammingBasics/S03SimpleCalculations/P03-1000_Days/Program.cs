using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        //Console.BackgroundColor = ConsoleColor.Yellow;
        //Console.ForegroundColor = ConsoleColor.Black;

        string inputDate = Console.ReadLine();

        DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy",CultureInfo.InvariantCulture);

        DateTime newDate=date.AddDays(999);

        Console.WriteLine(newDate.ToString("dd-MM-yyyy"));

        //Връща ден от седмицата
        //Console.WriteLine(newDate.DayOfWeek();
    }
}

