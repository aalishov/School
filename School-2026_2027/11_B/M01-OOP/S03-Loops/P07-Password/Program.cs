using System;
public class Program
{
    public static void Main()
    {
        string user = Console.ReadLine();
        string password = Console.ReadLine();
        string passwordInput = Console.ReadLine();
        while (password != passwordInput)
        {
            passwordInput = Console.ReadLine();
        }
        Console.WriteLine($"Welcome {user}!");
    }
}

