using System;
using System.Text;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        StringBuilder text = new StringBuilder();

        while (true)
        {
            string input = Console.ReadLine();
            if (input != "Purchase") { text.AppendLine(input); }
            else { break; }
        }
        string pattern = @">>(\w+)<<(\d+\.?\d+)!(\d+)";

        MatchCollection matches = Regex.Matches(text.ToString().TrimEnd(), pattern);

        Console.WriteLine($"Bought furniture:");

        double totalPrice = 0.0;

        foreach (Match item in matches)
        {
            Console.WriteLine(item.Groups[1]);
            double price = double.Parse(item.Groups[2].Value);
            int count = int.Parse(item.Groups[3].Value);
            totalPrice += (price * count);
        }

        Console.WriteLine($"Total money spent:\n{totalPrice:f2}");
    }
}
