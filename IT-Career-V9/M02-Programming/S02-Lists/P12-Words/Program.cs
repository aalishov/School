public class Program
{
    public static void Main()
    {

        char[] spliter = { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };

        List<string> words = Console.ReadLine()
            .Split(spliter, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> lowerCase = words
            .Where(w => !w.Any(s => char.IsUpper(s) || char.IsDigit(s)))
            .ToList();

        List<string> upperCase = words
            .Where(w => !w.Any(s => char.IsLower(s) || char.IsDigit(s)))
            .ToList();

        List<string> mixedCase = words
            .Where(w => (w.Any(s => char.IsLower(s)) && w.Any(s => char.IsUpper(s)))|| w.Any(s => char.IsDigit(s)))
            .ToList();


        Console.WriteLine(string.Join(", ", lowerCase));
        Console.WriteLine(string.Join(", ", mixedCase));
        Console.WriteLine(string.Join(", ", upperCase));
    }
}

