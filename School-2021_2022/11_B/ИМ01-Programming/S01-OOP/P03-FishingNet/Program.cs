using System;
using System.IO;

namespace P03_FishingNet
{
    class Program
    {
        static void Main()
        {
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            string[] fishInfo = File.ReadAllLines(inputPath);

            Console.WriteLine(string.Join($"{Environment.NewLine}",fishInfo));
        }
    }
}
