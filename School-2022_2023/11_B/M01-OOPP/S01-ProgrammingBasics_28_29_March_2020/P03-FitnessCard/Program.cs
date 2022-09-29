using System;


public class Program
{
    static void Main(string[] args)
    {
        double card = 0;

        double money = double.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        string sport = Console.ReadLine();
        if (gender == 'm')
        {
            switch (sport)
            {
                case "Gym":
                    card += 42;
                    break;
                case "Boxing":
                    card += 41;
                    break;
                case "Yoga":
                    card += 45;
                    break;
                case "Zumba":
                    card += 34;
                    break;
                case "Dances":
                    card += 51;
                    break;
                case "Pilates":
                    card += 39;
                    break;
            }
        }
        else
        {
            switch (sport)
            {
                case "Gym":
                    card += 35;
                    break;
                case "Boxing":
                    card += 37;
                    break;
                case "Yoga":
                    card += 42;
                    break;
                case "Zumba":
                    card += 31;
                    break;
                case "Dances":
                    card += 53;
                    break;
                case "Pilates":
                    card += 37;
                    break;
            }
        }
        if (age <= 19) { card -= card * 0.2; }
        if (money > card)
        {
            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
        }
        else
        {
            Console.WriteLine($"You don't have enough money! You need ${card - money:f2} more.");
        }
    }
}

