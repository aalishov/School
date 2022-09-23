using System;

public class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int totalWin = 0;
        int totalLose = 0;
        double totalProfit = 0;
        for (int i = 0; i < days; i++)
        {
            string sport = string.Empty;
            int currentDayWin = 0;
            int currentDayLose = 0;
            while ((sport = Console.ReadLine()) != "Finish")
            {
                string winOrLose = Console.ReadLine();
                if (winOrLose == "win") { currentDayWin++; }
                else { currentDayLose++; }
            }
            double dayProfit = currentDayWin * 20;
            if (currentDayWin > currentDayLose) { dayProfit *= 1.1; }
            totalWin += currentDayWin;
            totalLose += currentDayLose;
            totalProfit += dayProfit;
        }
        if (totalWin > totalLose) 
        { 
            totalProfit *= 1.2;
            Console.WriteLine($"You won the tournament! Total raised money: {totalProfit:f2}");
        }
        else
        {
            Console.WriteLine($"You lost the tournament! Total raised money: {totalProfit:f2}");
        }
    }
}

