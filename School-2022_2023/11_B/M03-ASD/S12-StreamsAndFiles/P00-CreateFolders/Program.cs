using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            File.Copy("file1.docx", $"{Guid.NewGuid().ToString()}.docx");
        }
    }
}
