using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        string input = Console.ReadLine();

        foreach (char c in input)
        {
            if (c!=' ')
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
        }

        foreach (var kvp in dic)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }

    }
}

