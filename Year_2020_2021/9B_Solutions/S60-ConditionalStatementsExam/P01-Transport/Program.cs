using System;

class Program
{
    static void Main()
    {
        double km = double.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        double totalPrice = 0;

        if (km < 20)
        {
            //taxi
            totalPrice += 0.70;

            if (dayOrNight == "day")
            {
                totalPrice += km * 0.79;
            }
            else if (dayOrNight == "night")
            {
                totalPrice += km * 0.9;
            }
        }
        else if (km >= 20 && km < 100)
        {
            //bus
            totalPrice += km * 0.09;
        }
        else if (km >= 100)
        {
            //train
            totalPrice += km * 0.06;
        }

        Console.WriteLine($"{totalPrice:f2}");
    }
}

