public class Program
{
    public static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.ToLower())
            .ToArray();

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordsCount.ContainsKey(word))
            {
                wordsCount[word]++;
            }
            else
            {
                wordsCount.Add(word, 1);
            }
        }

        foreach (var word in wordsCount)
        {
            if (word.Value % 2 == 1)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }                
        }
    }
}

