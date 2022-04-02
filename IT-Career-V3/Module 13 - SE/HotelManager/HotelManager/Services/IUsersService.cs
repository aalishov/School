using HotelManager.ViewModels.Users;
using System.Threading.Tasks;

namespace HotelManager.Services
{
    public interface IUsersService
    {
        Task CreateUserAsync(CreateUserViewModel model);
        Task DeleteUserAsync(string id);
        Task<IndexUsersViewModel> GetUsersAsync(int page, int itemsPerPage = 10);
    }
}