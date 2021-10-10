namespace SpaceStation.Repositories.Contracts
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> Models { get; }

        public void Add(T model);

        public bool Remove(T model);

        public T FindByName(string name);
    }
}
