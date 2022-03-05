using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P03_FishingNet
{
    class Program
    {
        static void Main()
        {
            Net net = new Net("cast net", 10);
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            IList<string> fishInfo = ReadFile(inputPath);

            foreach (var line in fishInfo)
            {
                net.AddFish(CreateFish(line));
            }

            string result =net.Report();
            Console.WriteLine(result);
            WriteFile(outputPath, result);

        }
        public static void WriteFile( string path, string data)
        {
            File.WriteAllText(path, data);
        }
        public static Fish CreateFish(string info)
        {
            string[] data = info.Split(' ');
            string type = data[0];
            double length = double.Parse(data[1]);
            double weight = double.Parse(data[2]);
            return new Fish(type,length,weight);
        }
        public static IList<string> ReadFile(string path)
        {
            return File.ReadAllLines(path).ToList();
        }
    }
}
