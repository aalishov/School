public class Program
{
    public static void Main()
    {
        double result = Sum(12.3, 25.6);

        Console.WriteLine(GedMiddleLetters("123"));
    }
    public static string GedMiddleLetters(string text="abcdef")
    {
        if (text.Length % 2 == 0)
        {
            return $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}";
        }
        return text[text.Length / 2].ToString();
    }
    public static char GetMiddleLetter(string text)
    {
        return text[text.Length / 2];
    }
    public static char GetFirstLetter(string text)
    {
        return text[0];
    }
    public static bool IsGreater(double a, double b)
    {
        if (a > b) { return true; }
        return false;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static double Sum(double a, double b)
    {
        return a + b;
    }
    public static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
}

