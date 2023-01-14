public class Program
{
    static void Main()
    {
        string s = "Hello, World!";
        char[] newS = s.ToCharArray();
        newS[0] = 'h';
        newS[7] = 'w';
        s = new string(newS);
        Console.WriteLine(s);
    }
}
