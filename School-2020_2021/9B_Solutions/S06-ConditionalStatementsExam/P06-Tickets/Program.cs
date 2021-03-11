using System;


public class Program
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        if (count >= 1 && count <= 4)
        {
            budget *= 0.25;
        }
        else if (count >= 5 && count <= 9)
        {
            budget *= 0.4;
        }
        else if (count >= 10 && count <= 24)
        {
            budget *= 0.5;
        }
        else if (count >= 25 && count <= 49)
        {
            budget *= 0.6;
        }
        else if (count >= 50)
        {
            budget *= 0.75;
        }

        double ticketsPrice = category == "VIP" ? count * 499.99 : count * 249.99;

        //if (category == "VIP")
        //{
        //    ticketsPrice = count * 499.99;
        //}
        //else if (category == "Normal")
        //{
        //    ticketsPrice = count * 249.99;
        //}

        double money = Math.Abs(budget - ticketsPrice);

        if (budget >= ticketsPrice)
        {
            Console.WriteLine($"Yes! You have {money:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {money:f2} leva.");
        }
    }
}

