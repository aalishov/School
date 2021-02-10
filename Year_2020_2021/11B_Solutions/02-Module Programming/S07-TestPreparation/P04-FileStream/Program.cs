using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\АлишАлишов\Desktop\GIT Projects\School-Repository\Year_2020_2021\11B_Solutions\02-Module Programming\S07-TestPreparation\P04-FileStream\demo.txt";

        
        StreamWriter writer = new StreamWriter(path, true);

        using (writer)
        {
            for (int i = 0; i < 50; i++)
            { 
                writer.WriteLine($"{i} - Add new line");
            }
            writer.Close();
        }

       StreamReader reader = new StreamReader(path);
        using(reader)
        {
            while (true)
            {
                if (reader.ReadLine()==null)
                {
                    break;
                }
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}

