using P01_Cars.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P01_Cars.Services
{
    public interface IOwnersService
    {
        Task CreateOwnerAsync(Owner owner);
        Task DeleteOwnerByIdAsync(string id);
        Task EditOwnerAsync(Owner owner);
        Task<Owner> GetOwnerByIdAsync(string id);
        Task<List<Owner>> GetOwnersAsync();
        bool OwnerExist(string id);
    }
}