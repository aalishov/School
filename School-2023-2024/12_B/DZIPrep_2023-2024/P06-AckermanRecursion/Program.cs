public class Program
{
    public static void Main(string[] args)
    {
        int result = Ack(1, 2);
        Console.WriteLine(result);
    }
    public static int Ack(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Ack(m - 1, 1);
        return Ack(m - 1, Ack(m, n - 1));
    }
}
