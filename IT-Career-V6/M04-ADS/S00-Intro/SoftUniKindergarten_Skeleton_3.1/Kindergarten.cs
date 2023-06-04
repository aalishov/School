using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        private readonly List<Child> children;

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            children = new List<Child>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public IReadOnlyList<Child> Registry { get { return children; } }

        public int ChildrenCount { get { return children.Count; } }

        public bool AddChild(Child child)
        {
            if (Capacity > children.Count)
            {
                children.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFullName)
        {
            Child child = GetChild(childFullName);
            return children.Remove(child);
        }


        public Child GetChild(string childFullName)
        {
            return children.FirstOrDefault(x => (x.FirstName + " " + x.LastName) == childFullName);
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Registered children in {Name}:");

            children
                .OrderByDescending(x => x.Age)
                .ThenBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .ToList()
                .ForEach(x => sb.AppendLine(x.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
