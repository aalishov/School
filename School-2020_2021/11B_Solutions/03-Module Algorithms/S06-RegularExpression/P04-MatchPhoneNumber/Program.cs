using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> phoneNumbers = new List<string>();

        string pattern = @"\+359 ?2 ?[0-9]{3} ?[0-9]{4}\b";
        string pattern2 = @"\+359-?2-?[0-9]{3}-?[0-9]{4}\b";

        string input = @"+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            phoneNumbers.Add(m.Value);
        }
        foreach (Match m in Regex.Matches(input, pattern2, options))
        {
            phoneNumbers.Add(m.Value);
        }

        Console.WriteLine(string.Join(", ",phoneNumbers));
    }
}

