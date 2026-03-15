public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine() ?? string.Empty;

        string digits = string.Empty;
        string uppers = string.Empty;
        string lowers = string.Empty;
        string others = string.Empty;

        foreach (var c in input)
        {

            if (char.IsUpper(c)) { uppers += c; }
            if (char.IsLower(c)) { lowers += c; }
            if (char.IsDigit(c)) { digits += c; }
            else { others += c; }
        }
        Console.WriteLine(uppers);
        Console.WriteLine(lowers);
        Console.WriteLine(digits);
    }
}