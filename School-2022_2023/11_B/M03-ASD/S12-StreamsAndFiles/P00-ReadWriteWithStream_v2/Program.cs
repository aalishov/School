using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string inputPath = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\11_B\\M03-ASD\\S12-StreamsAndFiles\\P00-ReadWriteWithStream_v2\\input.txt";
        string outputPath = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\11_B\\M03-ASD\\S12-StreamsAndFiles\\P00-ReadWriteWithStream_v2\\output.txt";

        using (StreamReader reader = new StreamReader(inputPath))
        {
            int count = 1;
            while (reader.Peek() != -1)
            {
                string result = $"{count}. {reader.ReadLine()}";
                count++;

                using (StreamWriter writer = new StreamWriter(outputPath,true))
                {
                    writer.WriteLine(result);
                }
            }
        }

        
    }
}

