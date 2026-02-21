public class Program
{
    public static void Main()
    {
        int a = 0;
        do
        {
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine()!);

        } while (a <= 50);
    }
}
