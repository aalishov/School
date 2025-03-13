using System.Text;

namespace CreaturesOfTheCode
{
    public class MythicalCreaturesHub
    {
        public MythicalCreaturesHub(int capacity)
        {

            Capacity = capacity;
            Creatures = new List<Creature>();
        }

        public List<Creature> Creatures { get; private set; }
        public int Capacity { get; private set; }
        public void AddCreature(Creature creature)
        {
            if (Creatures.Count < Capacity && !Creatures.Any(c => c.Name.ToLower() ==
            creature.Name.ToLower()))
            {
                Creatures.Add(creature);
            }

        }
        public bool RemoveCreature(string name)
        {
            Creature creature = Creatures.FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
            return Creatures.Remove(creature);
        }
        public Creature GetStrongestCreature()
        {
            return Creatures.OrderByDescending(c => c.Health).FirstOrDefault();

        }
        public string Details(string creatureName)
        {
            Creature creature = Creatures.FirstOrDefault(c => c.Name == creatureName);
            if (creature == null)
            {
                return $"Creature with the name {creatureName} not found.";
            }
            else
            {
                return creature.ToString();
            }
        }
        public string GetAllCreatures()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Mythical Creatures: ");
            foreach (Creature creature in Creatures.OrderBy(x=>x.Name))
            {
                result.AppendLine($"{creature.Name} -> {creature.Kind}");
            }
            return result.ToString().TrimEnd();
        }
    }
}
