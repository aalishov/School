public class Program
{
    static void Main()
    {
        Mushroom m = new Mushroom(30,30,-20);
        Hero h = new Hero(30, 30, 30, 100);
        h.Eat(m);
        Console.WriteLine(h);
    }
}

