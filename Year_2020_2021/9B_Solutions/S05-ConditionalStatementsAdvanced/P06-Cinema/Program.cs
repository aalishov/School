using System;

class Program
{
    const decimal PremierePrice = 12m;
    const decimal NormalPrice = 7.50m;
    const decimal DiscountPrice = 5.0m;
    static void Main()
    {
        string type = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        decimal ticketPrice = 0.0m;

        if (type== "Premiere")
        {
            ticketPrice = PremierePrice;
        }
        else if (type=="Normal")
        {
            ticketPrice = NormalPrice;
        }
        else if (type == "Discount")
        {
            ticketPrice = DiscountPrice;
        }

        decimal totalPrice = ticketPrice * row * col;

        Console.WriteLine($"{totalPrice:f2}");
    }
}

