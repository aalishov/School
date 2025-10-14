using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string pattern = @">>(\w*)<<(\d*\.?\d*)\!(\d+)";
        string input = @">>Sofa<<312.23!3
>>TV<<300!5
>Invalid<<!5
Purchase

";
        RegexOptions options = RegexOptions.Multiline;

        List<string> products = new List<string>();
        double sum = 0.0;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            products.Add(m.Groups[1].Value);
            sum += double.Parse(m.Groups[2].Value) * int.Parse(m.Groups[3].Value);
            //Console.WriteLine("'{0}' found at index {1}. => {2}", m.Value, m.Index, m.Groups[3]);
        }

        Console.WriteLine(string.Join(", ", products));
        Console.WriteLine(sum);
    }
}