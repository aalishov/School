using System;

class Program
{
    const double TaxiStartPrice = 0.70;
    const double TaxiDayPrice = 0.79;
    const double TaxiNightPrice = 0.9;
    const double BusPrice = 0.09;
    const double TrainPrice = 0.06;
    const int busMinKm = 20;
    const int trainMinKm = 100;
    static void Main()
    {
        double km = double.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        double totalPrice = 0;

        if (km < busMinKm)
        {
            //taxi
            totalPrice += TaxiStartPrice;

            if (dayOrNight == "day")
            {
                totalPrice += km * TaxiDayPrice;
            }
            else if (dayOrNight == "night")
            {
                totalPrice += km * TaxiNightPrice;
            }
        }
        else if (km >= busMinKm && km < trainMinKm)
        {
            //bus
            totalPrice += km * BusPrice;
        }
        else if (km >= trainMinKm)
        {
            //train
            totalPrice += km * TrainPrice;
        }

        Console.WriteLine($"{totalPrice:f2}");
    }
}

