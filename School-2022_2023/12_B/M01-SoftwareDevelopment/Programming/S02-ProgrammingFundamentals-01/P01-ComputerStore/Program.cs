using System;

public class Program
{
    public static void Main(string[] args)
    {
        decimal totalPrice = 0;
        decimal taxes = 0;
        decimal startingPrice = 0;
        bool isValid = true;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "special")
            {
                if (totalPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                    isValid = false;
                }
                startingPrice = totalPrice;
                taxes = totalPrice * 0.2m;
                totalPrice = (totalPrice + taxes) * 0.9m;
                break;
            }
            else if (input == "regular")
            {
                if (totalPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                    isValid = false;
                }
                startingPrice = totalPrice;
                taxes = totalPrice * 0.2m;
                totalPrice += taxes;
                break;
            }
            else
            {
                decimal price = decimal.Parse(input);
                if (price < 0) { Console.WriteLine("Invalid price!"); }
                else
                {
                    totalPrice += price;
                }
            }
        }
        if (isValid)
        {
            Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {startingPrice:f2}$\nTaxes: {taxes:f2}$");
            Console.WriteLine($"-----------\nTotal price: {totalPrice:f2}$");
        }
    }
}

