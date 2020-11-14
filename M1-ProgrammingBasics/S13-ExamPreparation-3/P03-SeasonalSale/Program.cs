using System;

class Program
{
    static void Main(string[] args)
    {
        string model = Console.ReadLine();
        string carType = Console.ReadLine();
        string season = Console.ReadLine();
        string condition = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());
        decimal wantedProfit = decimal.Parse(Console.ReadLine());

        decimal profitPercent = decimal.Zero;

        switch (condition)
        {
            case "perfect":
                //if (carType == "suv")
                //{
                //    profitPercent = 0.3m;
                //}
                //else
                //{
                //    profitPercent = 0.25m;
                //}
                profitPercent = SetPercentValue(carType, 0.3m, 0.25m);
                break;
            case "good":
                //if (carType == "suv")
                //{
                //    profitPercent = 0.2m;
                //}
                //else
                //{
                //    profitPercent = 0.15m;
                //}
                profitPercent = SetPercentValue(carType, 0.2m, 0.15m);
                break;
            case "bad":
                profitPercent = 0.1m;
                break;
        }

        decimal profit = price * profitPercent;

        if (season=="winter")
        {
            profit -= 200;
        }

        if (profit>=wantedProfit)
        {
            Console.WriteLine($"The profit on {model} will be good - {profit:f2} BGN");
        }
        else
        {
            decimal x = wantedProfit - profit;
            Console.WriteLine($"The car is not worth selling now{Environment.NewLine}Need {x:f2} more profit");
        }
    }

    private static decimal SetPercentValue(string carType, decimal percentSuv, decimal percentSedan)
    {
        decimal profitPercent;
        if (carType == "suv")
        {
            profitPercent = percentSuv;
        }
        else
        {
            profitPercent = percentSedan;
        }

        return profitPercent;
    }
}

