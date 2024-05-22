using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\d+";
        string input = Console.ReadLine();
        RegexOptions options = RegexOptions.Multiline;

        int sum = 0;
        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            sum+= int.Parse(m.Value);
        }
        Console.WriteLine(sum);
    }
}
