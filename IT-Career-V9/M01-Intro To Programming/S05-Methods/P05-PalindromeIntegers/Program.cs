public class Program
{
    public static void Main()
    {
        Run();
    }

    private static void Run()
    {
        while (true)
        {
            string word = Console.ReadLine();
            if (word == "END") { break; }
            Console.WriteLine(IsPalindrome(word));
        }
    }

    public static bool IsPalindrome(string input)
    {
        for (int i = 0; i < input.Length / 2; i++)
        {
            char f = input[i];
            char l = input[input.Length - 1 - i];
            if (f != l) { return false; }
        }
        return true;
    }
}

