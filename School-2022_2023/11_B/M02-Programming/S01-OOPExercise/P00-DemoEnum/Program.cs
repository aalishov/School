using System;

class Program
{
    static void Main(string[] args)
    {
        Date date = new Date()
        {
            Day = 2,
            Month = (Month)Enum.Parse(typeof(Month),Console.ReadLine(),true),
            Year = 2003
        };

        Console.WriteLine(date.Month);
    }
}

