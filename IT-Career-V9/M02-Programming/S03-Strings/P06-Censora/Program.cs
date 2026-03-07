using System.Text;

public class Program
{
    public static void Main()
    {
        string word = Console.ReadLine();
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder(input);
        sb.Replace(word, new string('*', word.Length));
        Console.WriteLine(sb);
    }
}

