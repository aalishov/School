using System;


public class Program
{
    public static void Main()
    {
        string[] input=Console.ReadLine().Split(", ");
        string text=Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            text = text.Replace(input[i], new string('*',input[i].Length)) ;
        }
        Console.WriteLine(text);
    }
}

