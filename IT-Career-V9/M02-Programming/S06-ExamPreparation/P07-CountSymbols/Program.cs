public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine() ?? string.Empty;
        //char[] input = Console.ReadLine().ToCharArray().Where(x => x != ' ').ToArray();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c == ' ') { continue; }
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount.Add(c, 1);
            }
        }

        foreach (var kvp in charCount)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}