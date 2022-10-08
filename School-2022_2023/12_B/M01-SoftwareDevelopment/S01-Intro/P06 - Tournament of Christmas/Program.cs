using System;
public class Program
{
    public static void Main()
    {
        int tournamentDays = int.Parse(Console.ReadLine());
        int winsTournaments = 0;
        int losesTournament = 0;
        double moneyWon = 0;
        for (int i = 0; i < tournamentDays; i++)
        {
            int wins = 0;
            int loses = 0;
            double moneyWonToday = 0;
            while (true)
            {
                string sport = Console.ReadLine();
                if (sport == "Finish")
                {
                    if (wins > loses) { moneyWonToday *= 1.1; }
                    winsTournaments += wins;
                    losesTournament += loses;
                    moneyWon += moneyWonToday;
                    break;
                }
                else
                {
                    bool isWinner = Console.ReadLine() == "win" ? true : false;
                    if (isWinner)
                    {
                        wins++;
                        moneyWonToday += 20;
                    }
                    else { loses++; }
                }
            }
        }
        if (winsTournaments > losesTournament)
        {
            moneyWon *= 1.2;
            Console.WriteLine($"You won the tournament! Total raised money: {moneyWon:f2}");
        }
        else
            Console.WriteLine($"You lost the tournament! Total raised money: {moneyWon:f2}");
    }
}

