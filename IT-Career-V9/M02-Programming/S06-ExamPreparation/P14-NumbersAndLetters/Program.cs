public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine() ?? string.Empty;

        string result = "";

        foreach (char c in input)
        {
            //c >= 'A' && c <= 'Z' Check if the character is an uppercase letter
            if (char.IsUpper(c))
            {
                result += c.ToString().ToLower();
            }
            else if (char.IsLower(c))
            {
                result += c.ToString().ToUpper();
            }
        }
        if (result != string.Empty)
        {
            Console.WriteLine(result);
        }
    }
}