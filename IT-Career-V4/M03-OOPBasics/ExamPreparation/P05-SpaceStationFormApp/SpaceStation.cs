using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace P05_SpaceStationFormApp
{
    public class SpaceStation
    {
        private readonly List<Astronaut> astronauts;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.astronauts = new List<Astronaut>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get => this.astronauts.Count; }
        public void Add(Astronaut astronaut)
        {
            if (this.astronauts.Count < this.Capacity)
            {
                this.astronauts.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
            return this.astronauts.Remove(GetAstronaut(name));
        }
        public Astronaut GetOldestAstronaut()
        {
            return this.astronauts.OrderBy(x => x.Age).LastOrDefault();
        }
        public Astronaut GetAstronaut(string name)
        {
            return this.astronauts.FirstOrDefault(x => x.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}");
            foreach (var a in this.astronauts)
            {
                sb.AppendLine($"=>{a.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }

        public override string ToString()
        {
            return Report();
        }
    }

}