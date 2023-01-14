using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i <= 1000; i++)
        {
            Console.WriteLine($"{i} => {(char)i}");
        }
    }
}
