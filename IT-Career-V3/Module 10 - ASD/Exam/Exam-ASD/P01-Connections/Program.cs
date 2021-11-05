using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Connections
{
    class Program
    {
        static List<string> connections = new List<string>();
        static List<string> inners = new List<string>();
        static List<string> used = new List<string>();
        static List<string> foundCons = new List<string>();
        static List<string> all = new List<string>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                connections.Add(input.Remove(1, 1));
                string inner = input.Split()[1];
                if (!all.Contains(input.Split()[0])) { all.Add(input.Split()[0]); }
                if (!all.Contains(inner)) { all.Add(inner); }
                if (!inners.Contains(inner)) { inners.Add(inner); }
                input = Console.ReadLine();
            }

            for (int i = 0; i < inners.Count; i++)
            {
                for (int j = 0; j < connections.Count; j++)
                {
                    if (connections[j][1].ToString() == inners[i])
                    {
                        string reversed = connections[j][1] + "" + connections[j][0];
                        string normal = connections[j][0] + "" + connections[j][1];
                        if (inners.Contains(connections[j][0].ToString()) && connections.Contains(reversed) && !used.Contains(normal))
                        {
                            used.Add(reversed);
                            foundCons.Add(inners[i] + " <-> " + connections[j][0].ToString());
                        }
                        else
                        {
                            Console.WriteLine("Disconnected");
                        }
                    }
                }
            }


            foreach (var i in all)
            {
                foreach (string item in foundCons.OrderBy(x => x))
                {
                    if (i.Contains(item[0]))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
