using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        decimal currentPrice = 0.0m;

        switch (type)
        {
            case "Premiere":
                currentPrice = premierePrice;
                break;
            case "Normal":
                currentPrice = normalPrice;
                break;
            case "Discount":
                currentPrice = discountPrice;
                break;
        }

        decimal totalPrice = row * col * currentPrice;

        Console.WriteLine($"{totalPrice:f2}");
    }

    const decimal premierePrice = 12m;
    const decimal normalPrice = 7.5m;
    const decimal discountPrice = 5m;
}

