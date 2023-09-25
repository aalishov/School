namespace YardGreeing
{
    using System;
    public class Program
    {
        static void Main()
        {
            double meters = double.Parse(Console.ReadLine());
            double price = meters * 7.61;
            double priceDiscount = price * 0.18;
            double tottalPrice = price - priceDiscount;

            Console.WriteLine($"The final price is: {tottalPrice} lv.The discount is: {priceDiscount} lv.");
        }
    }
}