public class Program
{
    public static void Main()
    {
        int[] n1 = { 1, 2, 3, 4 };
        int[] n2 = n1;
        int[] n3 = n2;

        n3[0] = 10;

        Console.WriteLine(string.Join(", ", n1));
        Console.WriteLine(string.Join(", ", n2));
        Console.WriteLine(string.Join(", ", n3));

    }


}

