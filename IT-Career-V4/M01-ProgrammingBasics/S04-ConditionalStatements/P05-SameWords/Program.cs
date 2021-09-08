using System;

class Program
{
    static void Main()
    {
        string firstWord = Console.ReadLine().ToLower();
        string secondWord = Console.ReadLine().ToLower();

        bool isSame = firstWord == secondWord;

        if (isSame)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

