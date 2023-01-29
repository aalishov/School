
namespace P01_Cars.Services
{
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OwnersService : IOwnersService
    {
        private readonly AppDbContext context;
        public OwnersService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Owner>> GetOwnersAsync()
        {
            return await context.Owners.ToListAsync();
        }

        public async Task<Owner> GetOwnerByIdAsync(string id)
        {
            return await context.Owners.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task CreateOwnerAsync(Owner owner)
        {
            if (owner != null)
            {
                Owner newOwner = new Owner()
                {
                    FirstName = owner.FirstName,
                    LastName = owner.LastName,
                    Birthdate = owner.Birthdate
                };
                context.Add(newOwner);
                await context.SaveChangesAsync();
            }
        }

        public async Task EditOwnerAsync(Owner owner)
        {
            if (owner != null)
            {
                Owner newOwner = await GetOwnerByIdAsync(owner.Id);

                newOwner.FirstName = owner.FirstName;
                newOwner.LastName = owner.LastName;
                newOwner.Birthdate = owner.Birthdate;
                context.Update(newOwner);
                await context.SaveChangesAsync();
            }
        }

        public bool OwnerExist(string id)
        {
            return context.Owners.Any(e => e.Id == id);
        }

        public async Task DeleteOwnerByIdAsync(string id)
        {
            var owner = await GetOwnerByIdAsync(id);
            context.Owners.Remove(owner);
            await context.SaveChangesAsync();
        }
    }
}
