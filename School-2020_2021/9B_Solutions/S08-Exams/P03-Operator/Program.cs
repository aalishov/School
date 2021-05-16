using System;

class Program
{
    static void Main(string[] args)
    {
        //Input
        string year = Console.ReadLine();
        string type = Console.ReadLine();
        string internet = Console.ReadLine();
        int months = int.Parse(Console.ReadLine());

        double price = 0.0;
        switch (type)
        {
            case "Small":
                if (year == "one") { price = 9.98; }
                else { price = 8.58; }
                break;
            case "Middle":
                if (year == "one") { price = 18.99; }
                else { price = 17.09; }
                break;
            case "Large":
                if (year == "one") { price = 25.98; }
                else { price = 23.59; }
                break;
            case "ExtraLarge":
                if (year == "one") { price = 35.99; }
                else { price = 31.79; }
                break;
        }
        if (internet == "yes")
        {
            if (price <= 10) { price += 5.5; }
            else if (price <= 30) { price += 4.35; }
            else if (price > 30) { price += 3.85; }
        }
        double totalPrice = price * months;
        if (year == "two") { totalPrice *= 0.9625; }
        //Output
        Console.WriteLine($"{totalPrice} lv.");
    }
}

