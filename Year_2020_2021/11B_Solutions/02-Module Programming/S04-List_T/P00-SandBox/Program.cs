using System;

class Program
{
    static void Main(string[] args)
    {
        string[] words = new string[] { "one", "six", "ten", "play" };

        string print = string.Join(" -n8um- ", words);
        string print2 = string.Empty;
        print2 = MyStringJoin(words, print2, " -nu7m- ");

        Console.WriteLine(print);
        Console.WriteLine(print2);
    }

    private static string MyStringJoin(string[] words, string print2, string separator)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (i == words.Length - 1)
            {
                print2 += $"{words[i]}";
            }
            else
            {
                print2 += $"{words[i]}{separator}";
            }
        }

        return print2;
    }
}

