using System;

class Program
{
    static void Main()
    {
        const decimal usd = 1.79549m;
        const decimal eur = 1.95583m;
        const decimal gbp = 2.53405m;

        decimal amount = decimal.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = Console.ReadLine();

        decimal result = decimal.Zero; // 0.00m

        if (input != "BGN" && output != "BGN")
        {
            string saveOutput= output;
            output = "BGN";
            if ((input == "USD" && output == "BGN") || (input == "BGN" && output == "USD"))
            {
                if (input == "USD")
                {
                    result = amount * usd;
                }
                else
                {
                    result = amount / usd;
                }
            }
            else if ((input == "EUR" && output == "BGN") || (input == "BGN" && output == "EUR"))
            {
                if (input == "EUR")
                {
                    result = amount * eur;
                }
                else
                {
                    result = amount / eur;
                }
            }
            else if ((input == "GBP" && output == "BGN") || (input == "BGN" && output == "GBP"))
            {
                if (input == "GBP")
                {
                    result = amount * gbp;
                }
                else
                {
                    result = amount / gbp;
                }
            }
            input = "BGN";
            output = saveOutput;
        }

        if ((input == "USD" && output == "BGN") || (input == "BGN" && output == "USD"))
        {
            if (input == "USD")
            {
                result = amount * usd;
            }
            else
            {
                result = amount / usd;
            }
        }
        else if ((input == "EUR" && output == "BGN") || (input == "BGN" && output == "EUR"))
        {
            if (input == "EUR")
            {
                result = amount * eur;
            }
            else
            {
                result = amount / eur;
            }
        }
        else if ((input == "GBP" && output == "BGN") || (input == "BGN" && output == "GBP"))
        {
            if (input == "GBP")
            {
                result = amount * gbp;
            }
            else
            {
                result = amount / gbp;
            }
        }

        Console.WriteLine($"{result:f2} {output}");
    }
}

