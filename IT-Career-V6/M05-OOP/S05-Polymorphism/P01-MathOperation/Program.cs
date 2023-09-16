public class Program
{
    public static void Main()
    {
        MathOperationAdvanced m = new MathOperationAdvanced();

        Console.WriteLine(m.Add(5, 12));
        Console.WriteLine(m.Add(2.3m, 15m, 8m));
        Console.WriteLine(m.Add(12.3d, 15.8d, 8d));
        Console.WriteLine(m.Add(12f, 2f, 14.6f));
       
    }
}
