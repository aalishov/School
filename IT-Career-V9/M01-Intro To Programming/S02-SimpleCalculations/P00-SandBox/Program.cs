public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        for (int i = 0; i < 2000; i++)
        {
            Console.WriteLine($"{i} -> {(char)i}");
        }
    }
}

