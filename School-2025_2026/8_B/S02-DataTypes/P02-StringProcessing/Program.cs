public class Program
{
    public static void Main()
    {
        string text = "C# is cool!";

        char firstLetter = text[0];
        char lastLetter= text[text.Length-1];

        Console.WriteLine($"Length: {text.Length}");
        Console.WriteLine($"First letter: {firstLetter}");
        Console.WriteLine($"Last letter: {lastLetter}");

        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.ToUpper());

        Console.WriteLine(text.IndexOf("cool"));
        Console.WriteLine(text.IndexOf("o")) ;
        Console.WriteLine(text.LastIndexOf("o"));

        Console.WriteLine(text.Substring(6));
        Console.WriteLine(text.Substring(6,4));
    }
}

