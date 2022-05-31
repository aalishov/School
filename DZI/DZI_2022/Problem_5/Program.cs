public class Program
{
    static void Main(string[] args)
    {

        counter(3);
    }
    private static void counter(int n)
    {
        if (n == 0)
            return;
        Console.Write(n);
        counter(n - 1);
    }
}
