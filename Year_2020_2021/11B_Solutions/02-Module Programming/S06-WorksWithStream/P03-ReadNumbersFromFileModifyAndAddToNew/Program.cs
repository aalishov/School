using System;
using System.IO;
class Program
{
    static void Main()
    {
        const string filePath = @"C:\Users\АлишАлишов\Desktop\GIT Projects\School-Repository\Year_2020_2021\11B_Solutions\02-Module Programming\S06-WorksWithStream\P03-ReadNumbersFromFileModifyAndAddToNew\newNumbers.txt";

        StreamReader reader = new StreamReader("numbers.txt");
        StreamWriter writer = new StreamWriter(filePath, false);

        using (reader)
        {
            using (writer)
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
                        int newNumber = int.Parse(line) * 10000;
                        writer.WriteLine($"#{newNumber}");
                        writer.WriteLine(new string('*', 30));
                    }
                }
            }
        }
        ReadFile(filePath);
    }
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

