namespace SpaceStation.Core
{
    using SpaceStation.Core.Contracts;
    using SpaceStation.Models.Astronauts;
    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Models.Mission;
    using SpaceStation.Models.Planets;
    using SpaceStation.Models.Planets.Contracts;
    using SpaceStation.Repositories;
    using SpaceStation.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private PlanetRepository planets;
        private static int exploredPlanets;

        public Controller()
        {
            this.astronauts = new AstronautRepository();
            this.planets = new PlanetRepository();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            switch (type)
            {
                case nameof(Biologist):
                    astronauts.Add(new Biologist(astronautName));
                    break;
                case nameof(Geodesist):
                    astronauts.Add(new Geodesist(astronautName));
                    break;
                case nameof(Meteorologist):
                    astronauts.Add(new Meteorologist(astronautName));
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
                    //break;
            }
            return string.Format(OutputMessages.AstronautAdded, type, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            foreach (var i in items)
            {
                planet.Items.Add(i);
            }
            this.planets.Add(planet);
            return string.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string ExplorePlanet(string planetName)
        {
            IPlanet planet = this.planets.FindByName(planetName);
            IList<IAstronaut> missionAstronauts = this.astronauts.Models.Where(x => x.Oxygen >= 60).ToList();
            if (!missionAstronauts.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }
            Mission mission = new Mission();
            mission.Explore(planet, missionAstronauts);
            exploredPlanets++;
            return string.Format(OutputMessages.PlanetExplored, planetName, missionAstronauts.Count(x => !x.CanBreath));
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exploredPlanets} planets were explored!");
            sb.AppendLine("Astronauts info:");
            foreach (var astronaut in this.astronauts.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");
                string itemsResult = astronaut.Bag.Items.Any() ? string.Join(", ", astronaut.Bag.Items) : "none";
                sb.AppendLine($"Bag items: {itemsResult}");
            }
            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = this.astronauts.FindByName(astronautName);
            if (this.astronauts.Remove(astronaut))
            {
                return string.Format(OutputMessages.AstronautRetired, astronautName);
            }
            throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
        }
    }
}
