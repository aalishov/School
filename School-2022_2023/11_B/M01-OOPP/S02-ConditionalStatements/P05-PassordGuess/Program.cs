using System;

public class Program
{
    static void Main()
    {
        string password = "s3cr3t!P@ssw0rd";
        string myPassword = Console.ReadLine();
        if (myPassword != password)
        {
            Console.WriteLine("Wrong password!");

        }
        else
        {
            Console.WriteLine("Welcome");
        }
    }
}

