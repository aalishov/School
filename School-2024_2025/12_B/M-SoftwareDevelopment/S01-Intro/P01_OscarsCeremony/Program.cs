public class Program
{
    public static void Main()
    {
        int rent = int.Parse(Console.ReadLine());
        double oscars = rent * 0.7;
        double keturing = oscars * 0.85;
        double sound = keturing * 0.5;
        Console.WriteLine($"{rent+oscars+keturing+sound:f2}");
    }
}

