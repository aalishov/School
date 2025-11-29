public class Program
{
    public static void Main()
    {
        string word1 = Console.ReadLine().ToUpper();
        string word2 = Console.ReadLine().ToUpper();

        if (word1 == word2)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

