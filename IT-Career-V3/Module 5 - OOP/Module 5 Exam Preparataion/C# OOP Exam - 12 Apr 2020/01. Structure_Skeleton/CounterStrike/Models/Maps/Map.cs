namespace CounterStrike.Models.Maps
{
    using CounterStrike.Models.Maps.Contracts;
    using CounterStrike.Models.Players;
    using CounterStrike.Models.Players.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    public class Map : IMap
    {
        private List<Terrorist> terrorists;
        private List<CounterTerrorist> counterTerrorists;
        public Map()
        {
            terrorists = new List<Terrorist>();
            counterTerrorists = new List<CounterTerrorist>();
        }
        public string Start(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                string playerType = player.GetType().Name;
                switch (playerType)
                {
                    case "Terrorist":
                        this.terrorists.Add(player as Terrorist);
                        break;
                    case "CounterTerrorist":
                        this.counterTerrorists.Add(player as CounterTerrorist);
                        break;
                }
            }


            while (terrorists.Any(x => x.IsAlive) && counterTerrorists.Any(x => x.IsAlive))
            {
                foreach (var terrorist in terrorists.Where(x=>x.IsAlive))
                {
                    foreach (var counterTerroist in counterTerrorists.Where(x=>x.IsAlive))
                    {
                        if (counterTerroist.IsAlive)
                        {
                            int damage = terrorist.Gun.Fire();
                            counterTerroist.TakeDamage(damage);
                        }
                    }
                }
                foreach (var counterTerrorist in counterTerrorists.Where(x => x.IsAlive))
                {
                    foreach (var terrorist in terrorists.Where(x => x.IsAlive))
                    {
                        if (terrorist.IsAlive)
                        {
                            int damage = counterTerrorist.Gun.Fire();
                            terrorist.TakeDamage(damage);
                        }
                    }
                }
            }

            if (counterTerrorists.Any(x=>x.IsAlive))
            {
                return $"Counter Terrorist wins!";
            }
            else
            {
                return $"Terrorist wins!";
            }
        }
    }
}
