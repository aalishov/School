
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int num = 0;
        while (num < n)
        {
            num += int.Parse(Console.ReadLine());

        }
        Console.WriteLine(num);
    }
}

