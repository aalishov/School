public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(RecFunc(3));
    }

    public static int RecFunc(int n)
    {
        if (n == 0) return 0;
        return (n % 2) + RecFunc(n / 2);
    }
}

