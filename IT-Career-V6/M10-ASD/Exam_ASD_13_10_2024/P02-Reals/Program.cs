using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Четене на входните данни
        int N = int.Parse(Console.ReadLine()); // Времето, което трябва да се запълни
        int M = int.Parse(Console.ReadLine()); // Броя на рийловете

        int[] reelLengths = new int[M];
        for (int i = 0; i < M; i++)
        {
            reelLengths[i] = int.Parse(Console.ReadLine()); // Дължини на рийловете
        }

        string command = Console.ReadLine(); // Командата - "details" или "count"

        // Инициализация на dp масива. dp[i] ще съдържа минималния брой рийлове за запълване на i секунди.
        int[] dp = new int[N + 1];
        int[] previousReel = new int[N + 1]; // Масив за проследяване на предишния рийл, който е използван
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0; // За 0 секунди не ни трябват рийлове

        // Жаден алгоритъм (подобен на Coin Change) за намиране на минималния брой рийлове
        for (int i = 0; i < M; i++)
        {
            int reel = reelLengths[i];
            for (int time = reel; time <= N; time++)
            {
                if (dp[time - reel] != int.MaxValue && dp[time - reel] + 1 < dp[time])
                {
                    dp[time] = dp[time - reel] + 1;
                    previousReel[time] = reel; // Запазваме кой рийл сме използвали за този резултат
                }
            }
        }

        if (command == "count")
        {
            // Извеждаме минималния брой рийлове, който трябва да се изгледат
            Console.WriteLine(dp[N]);
        }
        else if (command == "details")
        {
            // Проследяваме обратно кои рийлове са използвани
            Dictionary<int, int> usedReels = new Dictionary<int, int>();

            int currentTime = N;
            while (currentTime > 0)
            {
                int reel = previousReel[currentTime];
                if (!usedReels.ContainsKey(reel))
                {
                    usedReels[reel] = 0;
                }
                usedReels[reel]++;
                currentTime -= reel;
            }

            // Извеждаме резултата по желание
            foreach (var reel in usedReels.OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"{reel.Value} x {reel.Key} seconds");
            }
        }
    }
}
