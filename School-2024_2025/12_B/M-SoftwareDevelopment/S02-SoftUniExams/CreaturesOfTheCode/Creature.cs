using System.Text;

namespace CreaturesOfTheCode
{
    public class Creature
    {
        public Creature(string name, string kind, int health, string abilities)
        {
            Name = name;
            Kind = kind;
            Health = health;
            Abilities = abilities.Split(", ").ToList();
        }

        public string Name { get; private set; }
        public string Kind { get; private set; }
        public int Health { get; private set; }
        public List<string> Abilities { get; private set; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Name} ({Kind}) has {Health} HP");
            result.AppendLine($"Abilities: {string.Join(", ", Abilities)}");
            return result.ToString().TrimEnd();
        }

    }
}
