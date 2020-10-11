namespace EasterRaces.Repositories.Entities
{
    using EasterRaces.Models.Races.Contracts;
    using EasterRaces.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class RaceRepository : IRepository<IRace>
    {
        private readonly List<IRace> races;

        public RaceRepository()
        {
            this.races = new List<IRace>();
        }
        public void Add(IRace model)
        {
            this.races.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return races.AsReadOnly();
        }

        public IRace GetByName(string name)
        {
            return races.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IRace model)
        {
            return this.races.Remove(model);
        }
    }
}
