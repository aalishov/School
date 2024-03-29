public class Program
{
    public static void Main()
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        string input = Console.ReadLine();

        foreach (char item in input)
        {
            if (charCount.ContainsKey(item))
            {
                charCount[item]++;
            }
            else
            {
                charCount.Add(item, 1);
            }
        }

        charCount.Remove(' ');

        foreach (var item in charCount)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}

