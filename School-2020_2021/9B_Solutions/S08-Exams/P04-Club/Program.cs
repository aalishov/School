using System;

class Program
{
    static double sum = 0.0;
    static double profit = 0.0;
    static void Main()
    {
        ReadInput();

        Action();

        PrintOutput();
    }

    private static void ReadInput()
    {
        profit = double.Parse(Console.ReadLine());
    }

    private static void Action()
    {
        while (sum <= profit)
        {
            string cocktail = Console.ReadLine();
            if (cocktail == "Party!")
            {
                break;
            }

            int count = int.Parse(Console.ReadLine());
            double price = count * cocktail.Length;//cocktail.Length-цена на коктейл

            if (price % 2 == 0)
            {
                sum += price;
            }
            else
            {
                sum += (price * 0.75);
            }
        }
    }

    private static void PrintOutput()
    {
        if (profit > sum)
        {
            Console.WriteLine($"We need {profit - sum:f2} leva more.");
        }
        else
        {
            Console.WriteLine("Target acquired.");
        }

        Console.WriteLine($"Club income - {sum:f2} leva.");
    }
}

