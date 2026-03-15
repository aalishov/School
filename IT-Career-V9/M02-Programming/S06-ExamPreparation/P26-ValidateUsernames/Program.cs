
public class Program
{
    private static List<string> usernames = new List<string>();
    public static void Main()
    {
        usernames.AddRange((Console.ReadLine() ?? string.Empty).Split(", "));

        List<string> invalidUsernames = new List<string>();

        foreach (string username in usernames)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                invalidUsernames.Add(username);
                continue;
            }
            foreach (var c in username)
            {
                if (!(char.IsLetter(c) || char.IsDigit(c) || c == '_' || c == '-'))
                {
                    invalidUsernames.Add(username);
                    break;
                }
            }
        }
        
        usernames.RemoveAll(u => invalidUsernames.Contains(u));
        Console.WriteLine(string.Join(", ",usernames));
    }
}

