public class Program
{
    public static void Main()
    {
        Print1();
        Print2();
        Print3();
    }

    public static void Print1()
    {
        Console.WriteLine("Print 1");
    }
    public static void Print2()
    {
        Print1();
        Console.WriteLine("Pint2");
        Print1();
    }
    public static void Print3()
    {
        Console.WriteLine("Pint3");
        Print2();
    }
}
