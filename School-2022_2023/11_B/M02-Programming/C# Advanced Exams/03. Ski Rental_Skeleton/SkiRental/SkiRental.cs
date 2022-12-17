using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private readonly List<Ski> data;
        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Ski>();
        }
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int Count { get { return data.Count; } }

        public void Add(Ski ski)
        {
            if (Capacity >= this.data.Count)
            {
                this.data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            return this.data.Remove(GetSki(manufacturer, model));
        }
        public Ski GetSki(string manufacturer, string model)
        {
            return this.data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }
        public Ski GetNewestSki()
        {
            return this.data.OrderBy(x => x.Year).LastOrDefault();
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {this.Name}:");
            this.data.ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
