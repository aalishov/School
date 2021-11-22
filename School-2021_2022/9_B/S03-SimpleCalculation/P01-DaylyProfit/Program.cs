using System;

class Program
{
    static void Main()
    {
        //Вход
        int days = int.Parse(Console.ReadLine());
        double money = double.Parse(Console.ReadLine());
        double usd = double.Parse(Console.ReadLine());

        //Изчисления
        double montlyPayment = days * money;
        double totalPayment = montlyPayment * 12 + montlyPayment * 2.5;
        totalPayment -= totalPayment * 0.25;//totalPayment = totalPayment - totalPayment * 0.25;
        totalPayment *= usd; //totalPayment =totalPayment* usd;
        double averagePerDay = totalPayment / 365.0;

        //Изход
        Console.WriteLine(Math.Round(averagePerDay,2));
    }
}

