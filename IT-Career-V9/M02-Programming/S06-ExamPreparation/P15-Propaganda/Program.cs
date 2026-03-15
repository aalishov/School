public class Program
{
    private static Dictionary<string, int> words = new Dictionary<string, int>();
    public static void Main()
    {
        string[] input = (Console.ReadLine() ?? string.Empty).Split(", ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in input)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, 0);
            }
            words[word]++;
        }

        while (true)
        {
            string word = Console.ReadLine() ?? string.Empty;

            if (word == "END") { break; }
            if (words.ContainsKey(word)) { words[word]++; }
        }

        //Variant 1
        Dictionary<string, int> sortedWords = words.OrderByDescending(w => w.Value).ToDictionary(w => w.Key, w => w.Value);
        foreach (var word in sortedWords)
        {
            Console.WriteLine($"{word.Key}");
            break;
        }

        //Variant 2 
        //string result = words.OrderByDescending(w => w.Value).FirstOrDefault().Key;
        //Console.WriteLine(result);
    }
}