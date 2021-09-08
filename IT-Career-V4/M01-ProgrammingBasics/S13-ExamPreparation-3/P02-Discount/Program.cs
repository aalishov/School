using System;

class Program
{
    static void Main()
    {
        //Ctrl+K+U - uncomment
        //Ctrl+K+C - comment

        string model = Console.ReadLine();
        int vin = int.Parse(Console.ReadLine());
        string condition = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());

        decimal profit = 0.15m * price;

        bool isDiscount = condition == "good" && vin < 90000 && vin % 2 == 0 && profit > 400;

        if (isDiscount)
        {
            Console.WriteLine($"yes - {model}{Environment.NewLine}profit - {profit:f2}");
        }
        else
        {
            Console.WriteLine($"no");
            if (condition != "good")
            {
                Console.WriteLine($"The car is in bad condition");
            }
            if (vin >= 90000 || vin % 2 == 1)
            {
                Console.WriteLine($"VIN {vin} is not valid");
            }
            if (profit <= 400)
            {
                Console.WriteLine($"Cannot make discount, profit too low - {profit:f2}");
            }
        }


    }
}

