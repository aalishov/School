﻿namespace P18_Success_2_6_2
{
    public class Program
    {
        public static void Main()
        {
            string parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = $"{parent}/Info.txt";
            
            //string[] line = File.ReadAllLines(path);
            //Dictionary<string,int>towns = new Dictionary<string,int>();
            //foreach (var item in line)
            //{
            //    string[] info = item.Split(" - ").ToArray();
            //    if (towns.ContainsKey(info[1]))
            //    {
            //        towns[info[1]]++;
            //    }
            //    else
            //    {
            //        towns.Add(info[1], 1);  
            //    }
            //}
            //string townMostPopulated = towns.OrderByDescending(x => x.Value).FirstOrDefault().Key;
            //int count = towns.OrderByDescending(x => x.Value).FirstOrDefault().Value;
            //Console.WriteLine($"{townMostPopulated} {count}");


            Console.WriteLine(
                File.ReadAllLines(path)
                    .Select(x => x.Split(" - ").LastOrDefault())
                    .GroupBy(x => x)
                    .Select(g => new { Town = g.Key, Count = g.Count() })
                    .OrderByDescending(x => x.Count)
                    .Select(x => $"{x.Town} - {x.Count}")
                    .FirstOrDefault()
                );
        }
    }


}
