using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string words = "Hello, string processing string with string C#! string";

        StringBuilder builder = new StringBuilder(words);

        builder[1] = 'A';
        builder.Replace("string", "******");
        builder.AppendLine(" new text");
        builder.Append(" new text 2");

        for (int i = 0; i < 50; i++)
        {
            if (i % 2 == 0)
            {
                builder.AppendLine($"\t {i} => text");
            }
            else
            {
                builder.Append($"{i} => text");
            }
           
        }
        //builder.Remove(20,5);
        Console.WriteLine(builder);
        
    }
}

