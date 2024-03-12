public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(text.Count(x => x == ','));

        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ',')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
