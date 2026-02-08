public class Program
{
    public static void Main()
    {
        string w = Console.ReadLine();

        for (int i = 0; i < w.Length; i++)
        {
            Console.WriteLine($"{w[i]} -> {(int)(w[i] - 'a')}");
        }
    }
}

