using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Village
{
    public class Village
    {
        private readonly List<Peasant> peasants;
        private string name;
        private string location;

        public Village(string name, string location)
        {
            Name = name;
            Location = location;
            this.peasants = new List<Peasant>();
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
                if (value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentException("Location should be between 3 and 45 characters!");
                }
                location = value;
            }
        }

        public int Resource { get; set; }

        public void AddPeasant(Peasant peasant)
        {
            this.peasants.Add(peasant);
        }


        public int PassDay()
        {
            int resources = this.peasants.Sum(x => x.Productivity);
            this.Resource += resources;
            return resources;
        }

        public List<Peasant> KillPeasants(int count)
        {
            if (this.peasants.Count <= count)
            {
                return this.peasants;
            }
            else
            {
                List<Peasant> killedPeasants = this.peasants.Take(count).ToList();
                this.peasants.RemoveRange(0, count);
                return killedPeasants;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Village - {this.Name} ({this.Location})");
            sb.AppendLine($"Resources - {this.Resource}");
            sb.AppendLine($"Peasants – ({this.peasants.Count})");
            foreach (var p in this.peasants)
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }
    }

}