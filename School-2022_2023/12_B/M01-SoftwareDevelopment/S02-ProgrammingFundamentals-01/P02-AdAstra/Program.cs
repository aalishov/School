using System;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        ///#?\|?(\w+)#?\|?(\d{2}\/\d{2}\/\d{2})#?\|?(\d+)#?\|/gm
        ///
        string pattern = @"#?\|?(\w+ ?\w+ ?\w+)#?\|?(\d{2}\/\d{2}\/\d{2})#?\|?(\d+)#?\|?";
        string input = Console.ReadLine();// @"#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|";
        RegexOptions options = RegexOptions.Multiline;
        StringBuilder sb = new StringBuilder();
        int total = 0;
        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            //Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            //Console.WriteLine(m.Groups[1].Value);
            string bread = m.Groups[1].Value;
            string date= m.Groups[2].Value;
            string nutrition = m.Groups[3].Value;
            sb.AppendLine($"Item: {bread}, Best before: {date}, Nutrition: {nutrition}");
            total+=int.Parse(nutrition);
        }
        int days = total / 2000;
        string end = $"You have food to last you for: {days} days!{Environment.NewLine}";
        sb.Insert(0, end);
        Console.WriteLine(sb.ToString().TrimEnd());
    }
}

