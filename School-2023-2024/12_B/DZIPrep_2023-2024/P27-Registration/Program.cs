using System.Linq;

public class Program
{
    public static void Main()
    {
        string userName = Console.ReadLine();
        string[] input = Console.ReadLine().Split(" ").ToArray();
        string cmd = input[0];
        while (cmd != "Registration")
        {

            switch (cmd)
            {
                case "Letters":
                    if (input[1] == "Upper")
                    {
                        userName = userName.ToUpper();

                    }
                    else
                    {
                        userName = userName.ToLower();

                    }
                    Console.WriteLine(userName);
                    break;
                case "Reverse":
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    if (startIndex >= 0 && startIndex <= endIndex && endIndex < userName.Length)
                    {
                        Console.WriteLine(new string(userName.Substring(startIndex, endIndex - startIndex + 1).Reverse().ToArray()));
                    }
                    break;
                case "Substring":
                    string substring= input[1];
                    if (userName.Contains(substring))
                    {
                      userName=  userName.Replace(substring, "");
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        Console.WriteLine($"The username {userName} doesn't contain {substring}.");
                    }
                    break;
                case "Replace":
                    char letter = char.Parse(input[1]);
                   userName= userName.Replace(letter, '-');
                    Console.WriteLine(userName);
                    break;
                case "IsValid":
                    char symbol = char.Parse(input[1]);
                    if (userName.Contains(symbol))
                    {
                        Console.WriteLine("Valid username.");
                    }
                    else
                    {
                        Console.WriteLine($"{symbol} must be contained in your username.");
                    }
                    break;
                default:
                    break;
            }
            input = Console.ReadLine().Split(" ").ToArray();
            cmd = input[0];
        }


    }
}
