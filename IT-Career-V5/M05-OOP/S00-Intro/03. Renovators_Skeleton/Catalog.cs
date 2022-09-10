using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private readonly List<Renovator> renovators;

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.renovators = new List<Renovator>();
        }

        public IReadOnlyCollection<Renovator> Renovators
        {
            get { return this.renovators.AsReadOnly(); }
        }
        public string Name { get; private set; }
        public int NeededRenovators { get; private set; }
        public string Project { get; private set; }
        public int Count { get { return this.renovators.Count; } }
        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator's information.";
            }
            if (this.Count >= this.NeededRenovators)
            {
                return $"Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return $"Invalid renovator's rate.";
            }
            this.renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public bool RemoveRenovator(string name)
        {
            Renovator target = this.renovators.FirstOrDefault(x => x.Name == name);
            return this.renovators.Remove(target);
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            return this.renovators.RemoveAll(x => x.Type == type);
        }
        public Renovator HireRenovator(string name)
        {
            Renovator target = this.renovators.FirstOrDefault(x => x.Name == name);
            if (target != null)
            {
                target.Hired = true;
            }
            return target;
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> targetRenovators = new List<Renovator>();

            foreach (var renovator in this.renovators)
            {
                if (renovator.Days >= days)
                {
                    targetRenovators.Add(renovator);
                }
            }
            return targetRenovators;

            //return this.renovators.Where(x => x.Days >= days).ToList();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");

            foreach (var renovator in renovators.Where(x=>x.Hired==false))
            {
                sb.AppendLine(renovator.ToString());
            }

            //renovators.Where(x => x.Hired == false)
            //    .ToList()
            //    .ForEach(x => sb.AppendLine(x.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
