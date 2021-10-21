using System;

namespace P00_SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello C#!";

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 'a'; j <= 'z'; j++)
                {
                    for (int k = 'A'; k <= 'Z'; k++)
                    {
                        for (int l = 0; l <= 9; l++)
                        {
                            Console.WriteLine($"{i}{(char)j}{(char)k}{l}");
                        }
                    }
                }
            }
        }
    }
}
