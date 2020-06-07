namespace Ex01_FightingArena
{
    using System.Collections.Generic;
    using System.Linq;
    public class Arena
    {
        private readonly List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count { get { return gladiators.Count; } }
        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }
        public void Remove(string name)
        {
            Gladiator gladiator = gladiators.FirstOrDefault(x => x.Name == name);
            this.gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderByDescending(x => x.GetStatPower()).First();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderByDescending(x => x.GetWeaponPower()).First();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderByDescending(x => x.GetTotalaPower()).First();
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}
