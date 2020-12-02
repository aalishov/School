using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> resources = new Dictionary<string, int>();
        resources.Add("gold", 0);
        resources.Add("silver", 0);
        resources.Add("copper", 1);

        while (true)
        {
            string resourceName = Console.ReadLine().ToLower();
            if (resourceName=="stop")
            {
                break;
            }
            int value = int.Parse(Console.ReadLine());
            resources[resourceName] += value;
        }

        foreach (var resource in resources)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }
    }
}

