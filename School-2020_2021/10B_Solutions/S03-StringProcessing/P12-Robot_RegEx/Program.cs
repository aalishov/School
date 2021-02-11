using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> cmd = new List<string>();

        string pattern = @"([A-Z])([0-9]+)?";
        string input = @"L20R10LL20R10R30";
        RegexOptions options = RegexOptions.Multiline;

        var matches = Regex.Matches(input, pattern, options);

        foreach (Match m in matches)
        {
            for (int i = 1; i < m.Length; i++)
            {
                cmd.Add(m.Groups[i].ToString());
            }
        }
        Console.WriteLine(string.Join(" ", cmd));
    }
}

