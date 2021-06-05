using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Aquarium
{
    private readonly List<Fish> fishInPool;

    public Aquarium(string name, int capacity, int size)
    {
        this.Name = name;
        this.Capacity = capacity;
        this.Size = size;
        this.fishInPool = new List<Fish>();
    }

    public string Name { get; set; }

    public int Capacity { get; set; }

    public int Size { get; set; }

    public void Add(Fish fish)
    {
        if (fishInPool.Any(f => f.Name == fish.Name))
        {
            return;
        }
        else if (this.Capacity == this.fishInPool.Count)
        {
            return;
        }
        this.fishInPool.Add(fish);
    }

    public bool Remove(string name)
    {
        Fish fish = FindFish(name);
        return this.fishInPool.Remove(fish);
    }

    public Fish FindFish(string name)
    {
        return this.fishInPool.FirstOrDefault(f => f.Name == name);
    }

    public string Report()
    {
        StringBuilder sb = new StringBuilder($"Aquarium: {this.Name} ^ Size: {this.Size}{Environment.NewLine}");
        foreach (var fish in fishInPool)
        {
            sb.AppendLine(fish.ToString());
        }
        return sb.ToString().TrimEnd();
    }

    public override string ToString()
    {
        return Report();
    }
}

