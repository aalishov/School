public class Program
{
    public static void Main()
    {
        string text = "Hello, World!"; //immuntable

        string newText = text.Replace('l', 'r');

        Console.WriteLine(newText);

        foreach (var item in text)
        {
            Console.WriteLine(item);
        }
    }
}

