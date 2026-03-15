public class Program
{
    private static Dictionary<char, int> countLetters = new Dictionary<char, int>();
    public static void Main()
    {
        string input = (Console.ReadLine() ?? string.Empty).ToLower() ;

        foreach (char c in input)
        {
            if (!countLetters.ContainsKey(c))
            {
                countLetters.Add(c, 0);
            }
            countLetters[c]++;
        }
        //Variant 1
        //Dictionary<char, int> sortedLetters = countLetters
        //    .OrderByDescending(x => x.Value)
        //    .ThenBy(x => x.Key)
        //    .ToDictionary(x => x.Key, x => x.Value);

        //foreach (var c in sortedLetters)
        //{
        //    Console.WriteLine($"{c.Key.ToString().ToUpper()}");
        //    break;
        //}

        //Variant 2
        var result = countLetters
            .Where(x=>char.IsLetter(x.Key))
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .FirstOrDefault()
            .Key
            .ToString()
            .ToUpper();

        Console.WriteLine(result);
    }
}