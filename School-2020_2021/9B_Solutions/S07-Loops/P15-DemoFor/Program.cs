using System;


class Program
{
    static void Main()
    {
        for (int i = 5; i < 10; i++)
        {
            for (int j = 1; j < 4; j++)
            {
                for (int k = 'a'; k < 'c'; k++)
                {
                    for (int l = 8; l < 9; l++)
                    {
                        Console.WriteLine($"{i}{j}{(char)k}{l}");
                    }
                }
            }
        }
    }
}

