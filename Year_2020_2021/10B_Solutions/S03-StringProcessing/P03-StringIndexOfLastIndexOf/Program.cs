using System;


public class Program
{
    public static void Main()
    {
        string words = "Hello, string processing string with string C#! string";

        int result1 = words.IndexOf("string");
        int result2 = words.LastIndexOf("string");

        Console.WriteLine(result1);
        Console.WriteLine(result2);

        int counter = 0;
        int startIndex = 0;
        while (true)
        {
            string search = "string";

            int result = words.IndexOf(search, startIndex);
            if (result!=-1)
            {
                counter++;
                startIndex = result + search.Length;
            }
            else
            {
                Console.WriteLine($"{search} - {counter} maches");
                break;
            }
        }

    }
}

