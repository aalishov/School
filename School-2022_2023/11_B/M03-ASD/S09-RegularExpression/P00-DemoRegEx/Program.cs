using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

public class Example
{
    public static void Main()
    {
        string patternDate = @"(\d+-\w{3}-\d+)";
        string patterEmail = @"\w+@(\w+\.)+\w+";
        string input = @"I was born on 30-Dec-1994. My father was born on the 9-Jul-1955. 01-July-2000 is not a valid date. My email is demo@abv.bg.
";
        RegexOptions options = RegexOptions.Multiline;

        //MatchCollection mathces = Regex.Matches(input, patternDate, options);

        Regex regex = new Regex(patternDate, options);
        
        Match match = regex.Match(input);


        bool isMatch = regex.IsMatch(input);
        Console.WriteLine(isMatch);
        Console.WriteLine(match.Groups.Count);

        foreach (var item in match.Groups)
        {
            Console.WriteLine($"{item}");
        }


        string result = regex.Replace(input, DateTime.Now.AddDays(7).ToShortDateString());
        Console.WriteLine(result);

    }
}
