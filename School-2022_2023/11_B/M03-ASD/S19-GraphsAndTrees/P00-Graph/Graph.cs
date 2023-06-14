using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Graph<T>
{
    private Dictionary<T, List<T>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<T, List<T>>();
    }

    public void AddVertex(T vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<T>();
        }
    }

    public void AddEdge(T source, T destination)
    {
        if (!adjacencyList.ContainsKey(source))
        {
            adjacencyList[source] = new List<T>();
        }

        if (!adjacencyList.ContainsKey(destination))
        {
            adjacencyList[destination] = new List<T>();
        }

        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source);
    }

    public void RemoveVertex(T vertex)
    {
        if (adjacencyList.ContainsKey(vertex))
        {
            var neighbors = adjacencyList[vertex];

            foreach (var neighbor in neighbors)
            {
                adjacencyList[neighbor].Remove(vertex);
            }

            adjacencyList.Remove(vertex);
        }
    }

    public void RemoveEdge(T source, T destination)
    {
        if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
        {
            adjacencyList[source].Remove(destination);
            adjacencyList[destination].Remove(source);
        }
    }

    public List<T> GetNeighbors(T vertex)
    {
        if (adjacencyList.ContainsKey(vertex))
        {
            return adjacencyList[vertex];
        }

        return new List<T>();
    }

    public List<T> GetVertices()
    {
        return adjacencyList.Keys.ToList();
    }

    public bool HasEdge(T source, T destination)
    {
        if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
        {
            return adjacencyList[source].Contains(destination) && adjacencyList[destination].Contains(source);
        }

        return false;
    }

    public List<T> DepthFirstSearch(T startVertex)
    {
        List<T> result = new List<T>();
        HashSet<T> visited = new HashSet<T>();

        DFS(startVertex, visited, result);

        return result;
    }

    private void DFS(T vertex, HashSet<T> visited, List<T> result)
    {
        visited.Add(vertex);
        result.Add(vertex);

        foreach (var neighbor in adjacencyList[vertex])
        {
            if (!visited.Contains(neighbor))
            {
                DFS(neighbor, visited, result);
            }
        }
    }

    public List<T> BreadthFirstSearch(T startVertex)
    {
        List<T> result = new List<T>();
        HashSet<T> visited = new HashSet<T>();
        Queue<T> queue = new Queue<T>();

        visited.Add(startVertex);
        queue.Enqueue(startVertex);

        while (queue.Count > 0)
        {
            var vertex = queue.Dequeue();
            result.Add(vertex);

            foreach (var neighbor in adjacencyList[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        return result;
    }

}
