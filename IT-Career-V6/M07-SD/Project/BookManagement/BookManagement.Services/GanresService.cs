using BookManagement.Data;
using BookManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    public class GanresService
    {
        private AppDbContext context = new AppDbContext();

        public int Add(Ganre ganre)
        {
            if (string.IsNullOrWhiteSpace(ganre.Name))
            {
                throw new ArgumentException("Invalid ganre name!");
            }
            if (context.Ganres.Any(x => x.Name == ganre.Name))
            {
                throw new ArgumentException("Ganre already exist!");
            }

            this.context.Add(ganre);
            this.context.SaveChanges();
            return ganre.Id;
        }

        public Ganre? GetGanreById(int id)
        {
            return this.context.Ganres.Find(id);
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

        public int GetGenresCount()
        {
            return context.Ganres.Count();
        }

        public int EditGanre(int id, string name)
        {
            Ganre? ganre= context.Ganres.Find(id);
            if (ganre==null)
            {
                throw new ArgumentException("Ganre not found!");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid name!");
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
                throw new ArgumentException("Ganre not found!");
            }
            context.Ganres.Remove(ganre);
            context.SaveChanges();
            return id;
        }

    }
}
