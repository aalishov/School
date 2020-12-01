using System;

class Program
{
    const decimal usd = 1.79549m;
    const decimal eur = 1.95583m;
    const decimal gbp = 2.53405m;
    static void Main()
    {

        decimal amount = decimal.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = Console.ReadLine();

        decimal result = decimal.Zero; // 0.00m

        if (input != "BGN" && output != "BGN")
        {
            string saveOutput = output;
            output = "BGN";
            result = Convert(amount, input, output, result);
            input = "BGN";
            output = saveOutput;
            amount = result;
            result = decimal.Zero;
        }

        result = Convert(amount, input, output, result);

        Console.WriteLine($"{result:f2} {output}");
    }

    private static decimal Convert(decimal amount, string input, string output, decimal result)
    {
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

        return result;
    }
}

