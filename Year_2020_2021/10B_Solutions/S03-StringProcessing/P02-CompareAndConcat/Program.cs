using System;

public class Program
{
    public static void Main()
    {
        string word1 = "one";
        string word2 = "One";
        string word3 = "one";

        Console.WriteLine(word1 == word2);
        Console.WriteLine(word1 == word3);

        //Сравняване без разлика на главни и малки букви
        Console.WriteLine(string.Compare(word1, word2, true));

        Console.WriteLine(string.Concat(word1, " ", word2));
        Console.WriteLine(word1 + " " + word2);

    }
}

