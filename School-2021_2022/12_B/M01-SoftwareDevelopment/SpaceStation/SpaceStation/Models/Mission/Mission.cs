using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var a in astronauts)
            {
                while (planet.Items.Any() && a.CanBreath)
                {
                    a.Breath();
                    string item = planet.Items.Last();
                    a.Bag.Items.Add(item);
                    planet.Items.Remove(item);
                }
            }
        }
    }
}
