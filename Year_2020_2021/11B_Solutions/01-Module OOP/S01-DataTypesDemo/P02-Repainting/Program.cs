using System;

namespace P02_Repainting
{
    class Program
    {
        static void Main()
        {
            const decimal nylonPrice = 1.50m;
            const decimal pricePaint = 14.50m;
            const decimal paintThinnerPrice = 5m;

            Console.Write("Enter nylon quantity: ");
            int nylon = int.Parse(Console.ReadLine());
            Console.Write("Enter paint quantity: ");
            int paint = int.Parse(Console.ReadLine());
            Console.Write("Enter tinner quantity: ");
            int paintThinner = int.Parse(Console.ReadLine());
            Console.Write("Enter hour quantity: ");
            int hours = int.Parse(Console.ReadLine());

            nylon += 2;

            decimal nylonExpenses = nylon * nylonPrice;

            double nPaint = paint * 1.1;

            decimal paintExpenses = (decimal)nPaint * pricePaint;
            decimal tinnerExpenses = paintThinner * paintThinnerPrice;

            decimal totalExpenses = nylonExpenses + paintExpenses + tinnerExpenses + 0.40m;

            decimal workerExpenses = totalExpenses * 0.3m * hours;

            totalExpenses += workerExpenses;

            Console.WriteLine($"Total expenses: {totalExpenses:f2} lv.");
        }
    }
}
