public class Program
{
    public static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();
        List<char> chars = new List<char>();


        for (int i = 0; i < text.Length - 2; i++)
        {
            if (text[i] == 'A' && text[i + 1] == '*' && text[i + 2] == 'A')
            {
                chars.AddRange("sqr(A)".ToCharArray());
                i += 2;
            }
            else
            {
                chars.Add(text[i]);
            }
        }
        Console.WriteLine(string.Join("", chars));
    }
}
