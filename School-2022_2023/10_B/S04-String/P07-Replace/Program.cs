using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        StringBuilder sb = new StringBuilder();
        sb.Append(text);

        sb.Replace(word, $"{new string('*', word.Length)} ");

        Console.WriteLine(sb.ToString());
    }
}

