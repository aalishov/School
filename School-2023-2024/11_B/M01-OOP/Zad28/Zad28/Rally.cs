using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad28
{
    public class Rally
    {
        private List<Pilot> pilots;

        public Rally(string name, int year)
        {
            Name = name;
            Year = year;
            pilots = new List<Pilot>();
        }

        public string Name { get; set; }

        public int Year { get; set; }

        public void AddPilot(Pilot pilot)
        {
            pilots.Add(pilot);
        }

        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Rally: {Name} - {Year}");
            foreach (var pilot in pilots)
            {
                sb.AppendLine(pilot.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
