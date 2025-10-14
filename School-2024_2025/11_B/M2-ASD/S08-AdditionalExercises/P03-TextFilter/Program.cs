public class Program
{
    public static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
        string text = Console.ReadLine();

        foreach (string word in bannedWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}