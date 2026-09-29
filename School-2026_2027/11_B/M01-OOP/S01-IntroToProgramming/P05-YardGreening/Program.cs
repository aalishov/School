
using System;
public class Program
{
    public static void Main(string[] args)
    {
        double yardArea = double.Parse(Console.ReadLine());
        double pricePerSquareMeter = 7.61;
        double totalPrice = yardArea * pricePerSquareMeter;
        double discount = totalPrice * 0.18;
        Console.WriteLine($"The final price is: {totalPrice - discount:F2} lv.The discount is: {discount:F2} lv.");
    }
}

