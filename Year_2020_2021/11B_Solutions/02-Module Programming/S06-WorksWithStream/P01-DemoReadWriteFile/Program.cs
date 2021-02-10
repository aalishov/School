using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        //ReadFile("text.txt");
        //Console.WriteLine(new string('*', 30));
        //// ReadFile("covid.txt");
        //// ReadFile("Program.cs");

        StreamWriter writer = new StreamWriter("text.txt", true);
        using (writer)
        {
            for (int i = 0; i < 50; i++)
            {
                writer.WriteLine($"{i} => асдасдасдадас");
            }
            writer.Close();
        }
        ReadFile("text.txt");
    }

    // Метод за четена на файл
    private static void ReadFile(string fileName)
    {
        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}

