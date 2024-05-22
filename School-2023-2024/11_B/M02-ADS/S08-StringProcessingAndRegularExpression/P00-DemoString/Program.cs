using System.Text;

public class Program
{
    public static void Main()
    {
        //immutable
        string input = "Hello, World!";

        Console.WriteLine(input.ToUpper());
        Console.WriteLine(input.ToLower());
        Console.WriteLine(input.Substring(3, 2));
        Console.WriteLine(input.Substring(7));
        Console.WriteLine(input.IndexOf("llo"));
        Console.WriteLine(input.LastIndexOf("llo"));
        Console.WriteLine(input.IndexOf("l"));
        Console.WriteLine(input.LastIndexOf("l"));
        Console.WriteLine(input.LastIndexOf("z"));

        string newInput = input.Replace("Hello", "HELLO");
        Console.WriteLine(newInput);
        Console.WriteLine(new string('-',25));
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.AppendLine(", World!");
        sb[1] = 'E';
        Console.WriteLine(sb.ToString());
    }
}

