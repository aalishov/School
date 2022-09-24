using System;
internal class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double amount = 0;
        int totalWins = 0;
        int totalLoses = 0;

        for (int i = 0; i < days; i++)
        {
            string sport = null;
            int win = 0;
            int lose = 0;
            double profit = 0;
            while ((sport = Console.ReadLine()) != "Finish")
            {
                string result = Console.ReadLine();
                if (result == "win")
                {
                    profit += 20;
                    win++;
                }
                else { lose++; }

            }
            totalWins += win;
            totalLoses += lose;
            if (win > lose) { profit *= 1.1; }
            amount += profit;
        }
        if (totalWins > totalLoses)
        {
            amount *= 1.2;
            Console.WriteLine($"You won the tournament! Total raised money: {amount:f2}");
        }
        else
        {
            Console.WriteLine($"You lost the tournament! Total raised money: {amount:f2}");
        }

    }
}

