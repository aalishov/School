namespace EasterRaces.Repositories.Entities
{
    using EasterRaces.Models.Races.Entities;
    using System.Linq;
    public class RaceRepository:Repository<Race>
    {
        public override Race GetByName(string name)
        {
            return this.Models.FirstOrDefault(x=>x.Name==name);
        }
    }
}
