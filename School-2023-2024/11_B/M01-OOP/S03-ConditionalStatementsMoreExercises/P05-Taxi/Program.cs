using System;
namespace P05_Taxi
{
    public class Program
    {
        static void Main()
        {
            string m = Console.ReadLine();
            string dayOrNight = Console.ReadLine();
            double c = double.Parse(Console.ReadLine());
            double price = 0;
            if (m == "Jan" || m == "Feb" || m == "March" || m == "Apr")
            {
                if (dayOrNight == "Day") { price = 0.81; }
                else { price = 1.00; }
            }
            else if (m == "May" || m == "June" || m == "July" || m == "Aug")
            {
                if (dayOrNight == "Day")
                {
                    price = 0.91;
                }
                else
                {
                    price = 1.05;
                }
            }
            else
            {
                if (dayOrNight == "Day")
                {
                    price = 0.85;
                }
                else
                {
                    price = 1.03;
                }
            }
            Console.WriteLine($"Total cost: {price * c:f2}lv.");
        }
    }
}