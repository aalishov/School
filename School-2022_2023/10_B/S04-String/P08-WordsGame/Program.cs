using System;

public class Program
{
    public static void Main()
    {
        int maxPoints = 0;
        string winnerWord = string.Empty;

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "END OF GAME")
        {
            int points = 0;

            for (int i = 0; i < input.Length; i++)
            {
                points += input[i];
            }

            if (input[0] >= 'A' && input[0] <= 'Z') { points += 15; }
            if (input[input.Length - 1] == 't') { points += 20; }
            if (input.Length >= 10) { points += 30; }

            if (points > maxPoints)
            {
                maxPoints = points;
                winnerWord= input;
            }
        }
        Console.WriteLine($"Winner is word: {winnerWord}");
        Console.WriteLine($"Points: {maxPoints}");
    }
}

