public class Program
{
    public static void Main()
    {
        string winnerWord=string.Empty;
        int winnerPoints = 0;
        while (true)
        {
            string word = Console.ReadLine()!;
            if (word == "END OF GAME") { break; }

            int points = 0;
            foreach (var c in word)
            {
                points += c;
            }

            if (char.IsUpper(word[0])) { points += 15; }
            if (word[word.Length - 1] == 't') { points += 20; }
            if (word.Length >= 10) { points += 30; }

            if (points > winnerPoints)
            {
                winnerPoints = points;
                winnerWord = word;
            }
        }
        Console.WriteLine($"Winner is word: {winnerWord}");
        Console.WriteLine($"Points: {winnerPoints}");
    }
}