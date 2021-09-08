using System;

class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());

        string currentCurency = Console.ReadLine();
        string newCurency = Console.ReadLine();
        double result = 0.0;

        //USD to BGN
        if (currentCurency == sUsd && newCurency == sBgn)
        {
            result = money * usd;
        }
        // USD to EUR
        else if (currentCurency == sUsd && newCurency == sEur)
        {
            result = money * usd;
            result /= eur; //result=result/eur;
        }
        //BGN to EUR
        else if (currentCurency == sBgn && newCurency == sEur)
        {
            result = money / eur;
        }
        //EUR to GBP
        else if (currentCurency == sEur && newCurency == sGbp)
        {
            result = money *  eur;
            result /= gbp;
        }
        //TODO: Add convert othre currency

        //Output
        Console.WriteLine($"{Math.Round(result,2)} {newCurency}");
    }

    //Const
    const string sUsd = "USD";
    const string sEur = "EUR";
    const string sGbp = "GBP";
    const string sBgn = "BGN";
    const double usd = 1.79549;
    const double eur = 1.95583;
    const double gbp = 2.53405;
}

