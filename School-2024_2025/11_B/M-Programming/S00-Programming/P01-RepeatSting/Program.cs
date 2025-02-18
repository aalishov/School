public class Program
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int repeat = int.Parse(Console.ReadLine());
        Console.WriteLine(RepeatString(text, repeat));
    }
    static string RepeatString(string text, int repeat)
    {
        string result = "";

        for (int i = 0; i < repeat; i++)
        {
            result += text;
        }
        return result;
    }
}

