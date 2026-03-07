using System.Text;

public class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder(text);
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string cmd = input[0];

        switch (cmd)
        {
            case nameof(Append):
                Append(sb, input);
                break;
            case nameof(Remove):
                Remove(sb, input);
                break;
            case nameof(Insert):
                Insert(sb, input);
                break;
            case "Replace":
                Replace(sb, input);
                break;
            default:
                Default();
                break;
        }
    }

    private static void Default()
    {
        Console.WriteLine("Invalid command");
    }

    private static void Replace(StringBuilder sb, string[] input)
    {
        string oldValue = input[1];
        string newValue = input[2];
        sb.Replace(oldValue, newValue);
    }

    private static void Insert(StringBuilder sb, string[] input)
    {
        int index = int.Parse(input[1]);
        string add = input[2];
        sb.Insert(index, add);
    }

    private static void Append(StringBuilder sb, string[] input)
    {
        string add = input[1];
        sb.Append(add);
    }

    private static void Remove(StringBuilder sb, string[] input)
    {
        int startIndex = int.Parse(input[1]);
        int count = int.Parse(input[2]);
        sb.Remove(startIndex, count);
    }
}

