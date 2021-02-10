using System;

class Program
{
    static void Main(string[] args)
    {
        string model = Console.ReadLine();
        decimal price = decimal.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());

        decimal calculate = (price * 1.2m + 275m) + ((decimal)days * 20m);
        decimal profit = 0.15m * calculate;

        decimal carPrice = calculate + profit;
        Console.WriteLine($"The {model} with initial price of {price:f2} BGN will sell for {carPrice:f2} BGN");
        Console.WriteLine($"Profit: {profit:f2} BGN");
    }
}

