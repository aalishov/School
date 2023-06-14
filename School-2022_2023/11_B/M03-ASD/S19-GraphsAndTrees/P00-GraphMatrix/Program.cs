using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[][] graph = new string[n][];

        ReadMatrix(graph);

        PrintMatrix(graph);

        Paths(graph);
    }

    private static void Paths(string[][] graph)
    {
        for (int i = 1; i < graph.Length; i++)
        {
            for (int j = 1; j < graph[i].Length; j++)
            {
                if (graph[i][j] == "1")
                {
                    Console.WriteLine($"{graph[i][0]} --> {graph[0][j]}");
                }
            }
        }
    }

    private static void ReadMatrix(string[][] graph)
    {
        for (int i = 0; i < graph.Length; i++)
        {
            graph[i] = Console.ReadLine().Split(" ");
        }
    }

    private static void PrintMatrix(string[][] graph)
    {
        for (int i = 0; i < graph.Length; i++)
        {
            Console.WriteLine(string.Join(" ", graph[i]));
        }
    }
}

