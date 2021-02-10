using System;

class Program
{
    const decimal bitCoin = 1168;
    const decimal cny = 0.15m;
    const decimal usd = 1.76m;
    const decimal eur = 1.95m;
    static void Main(string[] args)
    {
        int citCoinNum = int.Parse(Console.ReadLine());
        decimal cnyNum = decimal.Parse(Console.ReadLine());
        decimal com = decimal.Parse(Console.ReadLine());

        decimal sumLeva = bitCoin*citCoinNum;

        decimal cnyToUsd = cnyNum * cny;
        sumLeva += cnyToUsd * usd;

        decimal euro = sumLeva / eur;

        decimal calcCum = euro * com / 100;
        euro -= calcCum;
        Console.WriteLine(Math.Round(euro,2));
    }
}

