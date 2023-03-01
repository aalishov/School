using System;

public class Program
{
    public static void Main()
    {
        //Input
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        //Calcualate seats
        int seats = rows * cols;
        double price = 0.0;

        //Set price
        if (type == "Premiere") { price = 12; }
        else if (type == "Normal") { price = 7.5; }
        else if (type == "Discount") { price = 5; }

        //Calculate total price
        double totalPrice = seats * price;

        //Output
        Console.WriteLine($"{totalPrice:f2}");
    }
}

