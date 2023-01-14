public class Program
{
    static void Main()
    {
        string s1 = "A";
        string s2 = "a";

        Console.WriteLine($"A=a => {s1==s2}");
        Console.WriteLine($"A>a => {string.Compare(s1,s2)}");
        Console.WriteLine($"a>A => {string.Compare(s2, s1)}");
        Console.WriteLine(s1.CompareTo(s2));
        Console.WriteLine("Ab".CompareTo("Ac"));
        
    }
}
