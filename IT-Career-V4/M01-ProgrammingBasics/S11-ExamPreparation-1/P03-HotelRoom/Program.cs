using System;


class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        decimal studioPrice = 0.0m;
        decimal apartmentPrice = 0.0m;

        switch (month)
        {
            case "May":
            case "October":
                apartmentPrice = 65m;
                studioPrice = 50m;
                if (n > 14)
                {
                    studioPrice *= 0.7m;
                }
                else if (n > 7)
                {
                    studioPrice *= 0.95m;
                }
                break;
            case "June":
            case "September":
                apartmentPrice = 68.7m;
                studioPrice = 75.2m;
                if (n>14)
                {
                    studioPrice *= 0.8m;
                }
                break;
            case "July":
            case "August":
                apartmentPrice = 77m;
                studioPrice = 76m;
                break;
        }

        if (n>14)
        {
            apartmentPrice *= 0.9m;
        }

        decimal apartmentTotal = n * apartmentPrice;
        decimal studioTotal = n * studioPrice;

        Console.WriteLine($"Apartment: {apartmentTotal:f2} lv.");
        Console.WriteLine($"Studio: {studioTotal:f2} lv.");

    }
}

