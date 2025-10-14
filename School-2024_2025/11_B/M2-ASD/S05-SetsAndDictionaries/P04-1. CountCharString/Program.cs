public class Program
{
    public static void Main(string[] args)
    {
        char[] text = Console.ReadLine().ToCharArray();
        var counts = new Dictionary<char, int>();
        foreach (char c in text.Where(x => x != ' '))
        {
            if (counts.ContainsKey(c))
            {
                counts[c]++;
            }
            else
            {
                counts[c] = 1;
            }
        }
        foreach (var c in counts)
        {
            Console.WriteLine($"{c.Key} - {c.Value}times");
        }
    }
}