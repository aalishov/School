public class Program
{
    public static void Main()
    {
        string text = "Hello, World!";
        string text2 = "      world     \n\n";
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.IndexOf("o"));
        Console.WriteLine(text.LastIndexOf("o"));
        Console.WriteLine(text.IndexOf("o", text.IndexOf("o")+1));
        Console.WriteLine(text.Replace("l","*"));
        Console.WriteLine(text.Substring(7,5));
        Console.WriteLine(text.Remove(7,5));
        Console.WriteLine(text2);
        Console.WriteLine(text2.TrimEnd());
    }
}

