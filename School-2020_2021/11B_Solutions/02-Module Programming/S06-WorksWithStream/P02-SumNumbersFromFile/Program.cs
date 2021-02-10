using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("numbers.txt");
        int sum = 0;

        using (reader)
        {
            while (true)
            {
                string line = reader.ReadLine();
                if (line==null)
                {
                    break;
                }
                bool isNum = int.TryParse(line, out _);
                if (isNum)
                {
                    sum += int.Parse(line);
                }
            }
            reader.Close();
        }
        Console.WriteLine($"Sum: {sum}");
    }
}

