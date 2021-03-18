using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();

        List<char> c = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (c.Any())
            {
                if (s[i]!=c.Last())
                {
                    c.Add(s[i]);
                }
            }
            else
            {
                c.Add(s[i]);
            }
        }
        Console.WriteLine(string.Join("",c));
    }
}

