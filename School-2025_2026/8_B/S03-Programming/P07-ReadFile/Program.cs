public class Program
{
    public static void Main()
    {
        string path = "data.txt";

        StreamReader reader = new StreamReader(path);

        string result = reader.ReadToEnd();

        Console.WriteLine(result);
    }
}