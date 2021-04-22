using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(VowelsCount("SoftUni"));
    }

    public static int VowelsCount(string word)
    {
        word = word.ToLower();
        //Vowels - a, e , i, o, u
        int counter = 0;

        for (int i = 0; i < word.Length; i++)
        {
            char symbol = word[i];
            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            {
                counter++;
            }
        }
        return counter;
    }
}

