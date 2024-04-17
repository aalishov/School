using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(?:=|\/)([A-Z][a-zA-Z]{2,})(?:=|\/)";
        string input = Console.ReadLine();
        RegexOptions options = RegexOptions.Multiline;
        List<string> args = new List<string>();

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            args.Add(m.Groups[1].Value);
        }
        if (args.Count > 0)
        {
            Console.WriteLine($"Destinations: {string.Join(", ", args)}");
            Console.WriteLine($"Travel Points: {args.Sum(x => x.Length)}");
        }
        else
        {
            Console.WriteLine($"Destinations:\r\nTravel Points: 0\r\n");
        }
    }
}
