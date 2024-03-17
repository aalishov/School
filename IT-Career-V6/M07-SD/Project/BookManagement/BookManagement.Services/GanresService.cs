namespace BookManagement.Services
{
    using Common;
    using Data;
    using Data.Models;

    public class GanresService
    {
        private AppDbContext context;
        public GanresService()
        {
            context = new AppDbContext();
        }
        public GanresService(AppDbContext context)
        {
            this.context = context;
        }

        public int Add(Ganre ganre)
        {
            if (string.IsNullOrWhiteSpace(ganre.Name))
            {
                throw new ArgumentException(ExceptionMessages.InvalidGanreName);
            }
            if (context.Ganres.Any(x => x.Name == ganre.Name))
            {
                throw new ArgumentException(ExceptionMessages.GanreAlreadyExyst);
            }

            this.context.Add(ganre);
            this.context.SaveChanges();
            return ganre.Id;
        }

        public Ganre? GetGanreById(int id)
        {
            return this.context.Ganres.Find(id);
        }

        public Ganre? GetGanreByName(string name)
        {
            return this.context.Ganres.FirstOrDefault(x => x.Name == name);
        }

        public List<Ganre> GetGanres(int page = 1, int itemsPerPage = 10, bool ascSort = true)
        {
            IQueryable<Ganre> result = null;

            if (ascSort)
            {
                result = this.context.Ganres.OrderBy(x => x.Name);
            }
            else
            {
                result = this.context.Ganres.OrderByDescending(x => x.Name);
            }

            return result
                  .Skip((page - 1) * itemsPerPage)
                  .Take(itemsPerPage)
                  .ToList();
        }

        public string[] GetAllGanres()
        {
            return this.context.Ganres.Select(x => x.Name).ToArray();
        }

        public int GetGenresCount()
        {
            return context.Ganres.Count();
        }

        public int EditGanre(int id, string name)
        {
            Ganre? ganre = context.Ganres.Find(id);
            if (ganre == null)
            {
                throw new ArgumentException(ExceptionMessages.GanreNotFound);
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(ExceptionMessages.InvalidGanreName);
            }
            ganre.Name = name;
            context.Ganres.Update(ganre);
            context.SaveChanges();
            return id;
        }

        public int DeleteGanre(int id)
        {
            Ganre? ganre = context.Ganres.Find(id);
            if (ganre == null)
            {
                throw new ArgumentException(ExceptionMessages.GanreNotFound);
            }
            context.Ganres.Remove(ganre);
            context.SaveChanges();
            return id;
        }

        public List<int> GetGanresId()
        {
            return this.context.Ganres.Select(x => x.Id).ToList();
        }
    }
}
