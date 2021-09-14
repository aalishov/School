namespace SpaceStation.Models.Mission
{
    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Models.Mission.Contracts;
    using SpaceStation.Models.Planets.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var a in astronauts)
            {
                while (a.CanBreath)
                {
                    string item = planet.Items.Last();

                    a.Bag.Items.Add(item);
                    planet.Items.Remove(item);
                    a.Breath();
                }
            }
        }
    }
}
