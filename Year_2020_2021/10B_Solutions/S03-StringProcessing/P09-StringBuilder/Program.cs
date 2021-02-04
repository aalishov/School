using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

        string cmd = input[0].ToLower();

        switch (cmd)
        {
            case "append":
                sb.Append(" " + string.Join(" ", input.Skip(1)));
                break;
            case "remove":
                sb.Remove(int.Parse(input[1]), int.Parse(input[2]));
                break;
            case "insert":
                sb.Insert(int.Parse(input[1]), " " + string.Join(" ", input.Skip(2)));
                break;
            case "replace":
                sb.Replace(input[1], input[2]);
                break;
            default:
                break;
        }

        Console.WriteLine(sb);
    }
}

