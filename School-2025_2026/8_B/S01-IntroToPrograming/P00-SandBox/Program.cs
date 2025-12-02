public class Program
{
    public static void Main()
    {
        Random r = new Random();
        HashSet<int> s = new HashSet<int>();
        while (s.Count<6)
        {
            s.Add(r.Next(1,49));
        }
        Console.WriteLine(string.Join(", ",s));
    }
}

