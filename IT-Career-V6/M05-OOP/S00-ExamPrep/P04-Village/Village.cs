using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village
{
    public class Village
    {
        private readonly List<Peasant> villagers = new List<Peasant>();
        private string name;
        private string location;

        public Village(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentException("Name should be between 2 and 40 characters!");
                }
                name = value;
            }
        }
        public string Location
        {
            get { return location; }
            set
            {
                if (value.Length<3||value.Length>45)
                {
                    throw new ArgumentException("Location should be between 3 and 45 characters!");
                }
                location = value;
            }
        }
        public int Resource { get; set; }
        public void AddPeasant(Peasant peasant)
        {
            villagers.Add(peasant);
        }
        public int PassDay()
        {
            Resource = villagers.Sum(x => x.Productivity);
            return Resource;
        }
        public List<Peasant> KillPeasants(int count)
        {
            List<Peasant> removed = villagers;
            if (villagers.Count<count)
            {
                Console.WriteLine(villagers);
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(removed[i]);
                }
            }
            villagers.RemoveRange(0,count);
            return villagers;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Village - {Name} ({Location})");
            sb.AppendLine($"Resources - {Resource}");
            sb.AppendLine($"Peasants – ({villagers.Count}))");
            villagers.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
