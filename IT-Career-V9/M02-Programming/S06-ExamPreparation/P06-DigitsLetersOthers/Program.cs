public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine() ?? string.Empty;

        string digits = string.Empty;
        string letters = string.Empty;
        string others = string.Empty;

        foreach (char c in input)
        {
            if (char.IsDigit(c)) { digits += c; }
            else if (char.IsLetter(c)) { letters += c; }
            else { others += c; }
        }

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(others);
    }
}
