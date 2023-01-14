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

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count { get=>renovators.Count;  }
        public string AddRenovator(Renovator renovator)
        {
            if (String.IsNullOrEmpty(renovator.Name))
            {
                return "Invalid renovator's information.";
            }
            else if (Count>=NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate>350)
            {
                return "Invalid renovator's rate.";
            }
            renovators.Add(renovator);            
            return $"Successfully added {renovator.Name} to the catalog.";
        }
        public 	bool RemoveRenovator(string name)
        {
            bool isRemoved = renovators.Remove(renovators.FirstOrDefault(x => x.Name == name));
            if (isRemoved)
            {
                //this.NeededRenovators++;
            }
            return isRemoved;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int renovators = this.renovators.RemoveAll(x => x.Type == type);
            //this.NeededRenovators -= renovators;
            return renovators;
        }
        public 	Renovator HireRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name == name);
            if (renovator!=null)
            {
                renovator.Hired = true;
                
            }
            return renovator;
        }
        public 	List<Renovator> PayRenovators(int days)
        {
            return renovators.Where(x => x.Days >= days).ToList();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var renovator in renovators.Where(x=>x.Hired==false))
            {
                renovator.ToString();
            }
            return sb.ToString().TrimEnd();
        }
    }
}
