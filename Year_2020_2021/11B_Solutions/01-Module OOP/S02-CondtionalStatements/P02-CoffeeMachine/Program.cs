using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        //Вход
        Console.Write("Type: ");
        string type = Console.ReadLine();
        Console.Write("Shugar: ");
        string shugar = Console.ReadLine();
        Console.Write("Numbers: ");
        int numbers = int.Parse(Console.ReadLine());

        decimal productPrice = default;

        //Определяне на цена за продукт
        productPrice = SelectPrice(type, shugar, productPrice);

        //Крайна цена
        decimal totalPrice = productPrice * numbers;

        //Изчисляване на отстъпка
        if (shugar == "Without")
        {
            totalPrice *= 0.65m;
        }
        if (type == "Espresso" && numbers >= 5)
        {
            totalPrice *= 0.75m;
        }
        if (totalPrice>bonusLimit)
        {
            totalPrice *= 0.8m;
        }

        //Изход
        Console.WriteLine($"You bought {numbers} cups of {type} for {totalPrice:f2} lv.");
    }


    //Определяне на цената
    private static decimal SelectPrice(string type, string shugar, decimal productPrice)
    {
        switch (type)
        {
            case "Espresso":
                switch (shugar)
                {
                    case "Without":
                        productPrice = EspressoWithoutShugar;
                        break;
                    case "Normal":
                        productPrice = Espresso;
                        break;
                    case "Extra":
                        productPrice = EspressoWithShugar;
                        break;
                }
                break;
            case "Cappuccino":
                switch (shugar)
                {
                    case "Without":
                        productPrice = CappWithoutShugar;
                        break;
                    case "Normal":
                        productPrice = Capp;
                        break;
                    case "Extra":
                        productPrice = CappWithShugar;
                        break;
                }
                break;
            case "Tea":
                switch (shugar)
                {
                    case "Without":
                        productPrice = teaWithoutShugar;
                        break;
                    case "Normal":
                        productPrice = tea;
                        break;
                    case "Extra":
                        productPrice = teaWithShugar;
                        break;
                }
                break;
        }

        return productPrice;
    }

    //Константи
    private const decimal EspressoWithoutShugar = 0.90m;
    private const decimal Espresso = 1m;
    private const decimal EspressoWithShugar = 1.2m;
    private const decimal CappWithoutShugar = 1m;
    private const decimal Capp = 1.2m;
    private const decimal CappWithShugar = 1.6m;
    private const decimal teaWithoutShugar = 0.5m;
    private const decimal tea = 0.6m;
    private const decimal teaWithShugar = 0.7m;
    private const decimal bonusLimit = 15m;

}

