using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());



        minutes += 15;

        if (minutes >= 60)
        {
            hours++; //hours=hours+1;
            minutes -= 60; //minutes=minutes-60;
        }
        if (hours > 23)
        {
            hours = 0;
        }
        if (minutes < 10)
        {
            Console.WriteLine($"{hours}:0{minutes}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }


        //DateTime dateTime = DateTime.ParseExact($"{hours}:{minutes}", "H:m", CultureInfo.InvariantCulture);
        //DateTime newTime = dateTime.AddMinutes(15);
        //Console.WriteLine(newTime.ToString("H:mm"));

    }
}

