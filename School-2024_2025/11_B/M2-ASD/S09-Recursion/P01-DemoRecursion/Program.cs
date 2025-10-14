public class Program
{
    public static void Main()
    {
       int result= ack(10, 10);
        Console.WriteLine(result);
    }

    static int ack(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return ack(m - 1, 1);
        return ack(m - 1, ack(m, n - 1));
    }
}