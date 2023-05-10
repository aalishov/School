using System;
using System.IO;
using System.Text;

public class Program
{
    public static void Main()
    {
        string inputPath = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\11_B\\M03-ASD\\S12-StreamsAndFiles\\P00-ReadWriteWithStream\\input.txt";
        string outputPath = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\11_B\\M03-ASD\\S12-StreamsAndFiles\\P00-ReadWriteWithStream\\output.txt";

        StringBuilder sb = new StringBuilder();

        string[] lines = null;

        using (StreamReader reader = new StreamReader(inputPath))
        {
            lines = reader.ReadToEnd().Split(Environment.NewLine);
        }

        for (int i = 0; i < lines.Length; i++)
        {
            try
            {
                string[] args = lines[i].Split(" ");
                string cmd = args[0];
                double a = double.Parse(args[1]);
                double b = double.Parse(args[2]);
                string result = string.Empty;

                switch (cmd)
                {
                    case "+":
                        result = $"{a} + {b} = {a + b}";
                        break;
                    case "-":
                        result = $"{a} - {b} = {a - b}";
                        break;
                    case "*":
                        result = $"{a} * {b} = {a * b}";
                        break;
                    case "/":
                        result = $"{a} / {b} = {a / b}";
                        break;
                    default:
                        break;
                }

                sb.AppendLine(result);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        using (StreamWriter writer = new StreamWriter(outputPath, false))
        {
            writer.WriteLine(sb.ToString().TrimEnd());
        }
    }
}

