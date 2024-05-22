using System;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string pattern = @">>(\w+)<<(\d+[.\d]*)!(\d+)";

        StringBuilder multiline = new StringBuilder();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Purchase") { break; }
            else { multiline.AppendLine(input); };
        }

        RegexOptions options = RegexOptions.Multiline;

        double total = 0.0;
        foreach (Match m in Regex.Matches(multiline.ToString(), pattern, options))
        {
            Console.WriteLine($"{m.Groups[1]}");
            total += double.Parse(m.Groups[2].Value) * double.Parse(m.Groups[3].Value);
        }

        Console.WriteLine($"Total money spent: {total}");
    }
}
