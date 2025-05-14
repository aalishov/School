using System;
public class Program
{
    public static void Main()
    {
		try
		{
            string username = Console.ReadLine();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                string cmd = input[0];
                switch (cmd)
                {
                    case "Letters":
                        if (input[1] == "Upper") { username = username.ToUpper(); }
                        else { username = username.ToLower(); }
                        Console.WriteLine(username);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(input[1]);
                        int endIndex = int.Parse(input[2]);
                        string substring = username.Substring(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(string.Join("", substring.Reverse()));
                        break;
                    case "Substring":
                        string checkSubstring = input[1];
                        int substringStartIndex = username.IndexOf(checkSubstring);
                        if (substringStartIndex != -1)
                        {
                            //username = username.Substring(0, substringStartIndex) + username.Substring(substringStartIndex + checkSubstring.Length);
                            username = username.Replace(checkSubstring, "");
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The username {username} doesn't contain {checkSubstring}.");
                        }
                        break;
                    case "Replace":
                        char replace = input[1][0];
                        username = username.Replace(replace, '-');
                        Console.WriteLine(username);
                        break;
                    case "IsValid":
                        char c = input[1][0];
                        if (username.Contains(c))
                        {
                            Console.WriteLine("Valid username.");
                        }
                        else
                        {
                            Console.WriteLine($"{c} must be contained in your username.");
                        }
                        break;
                    case "Registration":
                        Environment.Exit(0);
                        break;

                }
            }
        }
		catch (Exception ex)
		{
            Console.WriteLine(ex.Message);
		}
    }
}