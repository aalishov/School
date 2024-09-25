public class Program
{
    public static void Main()
    {
        int pen = int.Parse(Console.ReadLine());
        int markers = int.Parse(Console.ReadLine());
        int materials = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        double total = pen * 5.80 + markers * 7.20 + materials * 1.20;
        double discountValue = total * discount / 100.0;
        total-=discountValue;

        Console.WriteLine(total);
    }
}

