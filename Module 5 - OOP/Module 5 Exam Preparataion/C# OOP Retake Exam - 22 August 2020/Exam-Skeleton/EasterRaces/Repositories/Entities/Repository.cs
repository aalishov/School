namespace EasterRaces.Repositories.Entities
{
    using EasterRaces.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Repository<T> : IRepository<T>
    {
        protected Repository()
        {
            this.Models = new List<T>();
        }
        protected List<T> Models { get; set; }
        public void Add(T model)
        {
            this.Models.Add(model);
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return this.Models.AsReadOnly();
        }

        public virtual T GetByName(string name)
        {
            return this.Models.FirstOrDefault();
        }

        public bool Remove(T model)
        {
            return this.Models.Remove(model);
        }
    }
}
