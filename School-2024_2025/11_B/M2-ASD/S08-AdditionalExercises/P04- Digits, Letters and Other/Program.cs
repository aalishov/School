
public class Program
{
    public static void Main(string[] args)
    {
        string digits = string.Empty;
        string letters = string.Empty;
        string other = string.Empty;
        string text = Console.ReadLine();
        foreach (char c in text)
        {
            if (char.IsDigit(c))
            {
                digits += c;
            }
            else if (char.IsLetter(c))
            {
                letters += c;
            }
            else 
            {
                other += c;
            }
        }
        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(other);

    }
}

