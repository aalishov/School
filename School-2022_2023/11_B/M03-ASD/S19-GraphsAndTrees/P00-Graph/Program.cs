using System;


public class Program
{
  public  static void Main()
    {
        var graph = new Graph<int>();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);

        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 1);

        var neighbors = graph.GetNeighbors(2);
        Console.WriteLine(string.Join(", ", neighbors));
        // Изход: 1, 3

        var vertices = graph.GetVertices();
        Console.WriteLine(string.Join(", ", vertices));
        // Изход: 1, 2, 3, 4

        Graph<string> graph2 = new Graph<string>();
        graph2.AddVertex("A");
        graph2.AddVertex("F");
        graph2.AddVertex("D");
        graph2.AddVertex("G");
        graph2.AddVertex("J");

        graph2.AddEdge("A","F");
        graph2.AddEdge("A", "D");
        graph2.AddEdge("F", "D");
        graph2.AddEdge("F", "G");
        graph2.AddEdge("F", "J");
        graph2.AddEdge("G", "D");
        graph2.AddEdge("G", "J");

        var result = graph2.DepthFirstSearch("J");
        Console.WriteLine(string.Join(", ",result));
    }
}

