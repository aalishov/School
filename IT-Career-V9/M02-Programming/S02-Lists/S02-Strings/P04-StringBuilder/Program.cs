using System.Text;

public class Program
{
    public static void Main()
    {
        List<string> names= new List<string>() { "Alice", "Bob", "Charlie" };
        StringBuilder sb = new StringBuilder("Hello, World!");
        sb[0] = 'h';
        sb[sb.Length - 1] = '.';
        sb.AppendLine("\nHow are you?");
        sb.Insert(sb.ToString().IndexOf('.')+1, "\nGreeting: ");

        sb.AppendJoin(", ", names);
        Console.WriteLine(sb);
    }
}

