using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line = "";
            while (line != null)
            {
                line = reader.ReadLine();
                Console.WriteLine($"=>{line}");
            }
        }

        using (StreamWriter writer = new StreamWriter("input.txt", true))
        {
            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();
            writer.WriteLine(brand);
        }
    }
}

