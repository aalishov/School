using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Program
{
    static void Main(string[] args)
    {
        List<string> comma = new List<string>();
        string pattern = @"[,]";
        string input = Console.ReadLine();
        RegexOptions options = RegexOptions.Multiline;
        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            comma.Add(m.Value);
        }
        foreach (Match m in Regex.Matches(input, pattern, options))
        { comma.Add(m.Value); }
        Console.WriteLine(string.Join(", ", comma));
    }
}