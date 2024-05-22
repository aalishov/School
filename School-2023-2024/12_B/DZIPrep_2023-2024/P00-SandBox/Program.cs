
public class Example
{
    public static void Main()
    {
        int[] a = new int[1] { 5 };
        Increase(a);
        Console.WriteLine(a[0]);

    }
    public static void Increase(int[] a)
    {
        for (int i = 0; i < 10; i++)
        {
            a[0]+=1;
        }
    }
}




