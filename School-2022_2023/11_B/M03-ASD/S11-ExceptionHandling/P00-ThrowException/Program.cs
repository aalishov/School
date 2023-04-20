using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Student s = new Student("John", "Jameson", -15);
        }
        catch (InvalidNameException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Bye, bye...");
        }
    }
}

