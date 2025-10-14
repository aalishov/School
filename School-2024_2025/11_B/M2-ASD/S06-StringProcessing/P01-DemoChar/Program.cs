public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"char.IsDigit( '0' ) = {char.IsDigit('0')}");
        Console.WriteLine($"char.IsLetter('!') = {char.IsLetter('!')}");


        for (int i = 'A'; i <= 'Z'; i++)
        {
            Console.WriteLine($"{i} = {(char)i}");
        }
    }
    public static bool MyIsDigit(char c)
    {
        if (c >= 48 && c < 57)
        {
            return true;
        }
        return false;
    }
}

