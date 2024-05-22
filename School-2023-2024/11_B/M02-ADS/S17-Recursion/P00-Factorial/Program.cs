public class Program
{
    public static void Main()
    {
        GetFactorial(4);
    }

    public static long GetFactorial(int num)
    {
        if (num == 0)
            return 1;

        return num * GetFactorial(num - 1);
    }
}

