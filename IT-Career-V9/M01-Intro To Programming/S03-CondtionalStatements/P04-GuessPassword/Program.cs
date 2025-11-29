public class Program
{
    private const string Password = "s3cr3t!P@ssw0rd";
    public static void Main()
    {
        string userPassword = Console.ReadLine();

        if (userPassword == Password)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}

