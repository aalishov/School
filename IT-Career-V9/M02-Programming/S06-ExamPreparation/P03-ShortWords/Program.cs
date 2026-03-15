
public class Program
{
    public static void Main()
    {
        char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '_', '(', ')', '[', ']', '{', '}', '"', '\'', '\\', '/' };

        List<string> result = Console.ReadLine()!
            .Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '_', '(', ')', '[', ']', '{', '}', '"', '\'', '\\', '/' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length < 5)
            .Select(x => x.ToLower())
            .Distinct()
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(string.Join(" ", result));
    }
}