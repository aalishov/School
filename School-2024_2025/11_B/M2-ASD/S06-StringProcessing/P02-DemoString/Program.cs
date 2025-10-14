using System.Text;

public class Program
{
    public static void Main()
    {
        //immutable
        string s1 = "Coding with";
        string s2 = s1 + " C#";

        Console.WriteLine($"s2.ToUpper() - {s2.ToUpper()}");
        Console.WriteLine($"s2.IndexOf(\"C#\")-{s2.IndexOf("i")}");
        Console.WriteLine($"s2.LastIndexOf(\"C#\")-{s2.LastIndexOf("i")}");

        //"Coding with C#"
        Console.WriteLine($"s2.Substring(4,2) - {s2.Substring(4, 2)}");
        Console.WriteLine(s2.Replace("i", "*"));
        Console.WriteLine(new string('-',20));
        StringBuilder sb = new StringBuilder();
        sb.Append("Coding with");
        sb.AppendLine(" C#");
        sb.Append("Author: Nakov");
        sb.Insert(12, "-----");
        Console.WriteLine(sb.ToString());
        sb.Replace("-", "*");
        Console.WriteLine(sb.ToString());
        sb[0] = 'c';
        Console.WriteLine(sb.ToString());
    }
}