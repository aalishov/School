using System;

public class Program
{
    public static void Main()
    {
        int km = int.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        double totalPrice = 0;

        if (km < 20)
        {
            totalPrice += 0.7;
            if (dayOrNight == "day") { totalPrice += (km * 0.79); }
            else { totalPrice += (km * 0.9); }
        }
        else if (km >= 20 && km < 100)
        {
            totalPrice += (km * 0.09);
        }
        else if (km >= 100)
        {
            totalPrice += (km * 0.06);
        }

        Console.WriteLine(totalPrice);
    }
}
