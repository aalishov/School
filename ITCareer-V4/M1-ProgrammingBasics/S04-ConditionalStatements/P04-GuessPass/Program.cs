using System;

class Program
{
    static void Main()
    {
        const string pass = "s3cr3t!P@ssw0rd";

        string readPass = Console.ReadLine();
        if (pass==readPass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}

