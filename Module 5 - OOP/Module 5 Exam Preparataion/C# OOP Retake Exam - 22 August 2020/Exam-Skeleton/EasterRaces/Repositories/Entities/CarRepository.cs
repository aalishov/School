namespace EasterRaces.Repositories.Entities
{
    using System.Linq;
    using EasterRaces.Models.Cars.Contracts;
    public class CarRepository : Repository<ICar>
    {
        public override ICar GetByName(string name)
        {
            return Models.FirstOrDefault(x => x.Model == name);
        }
    }
}
