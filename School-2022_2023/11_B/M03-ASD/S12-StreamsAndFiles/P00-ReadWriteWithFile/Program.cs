using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string inputPath = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\11_B\\M03-ASD\\S12-StreamsAndFiles\\P00-ReadWriteWithFile\\input.txt";

        string[] result = File.ReadAllLines(inputPath);


        Console.WriteLine(string.Join(Environment.NewLine,result));
    }
}

