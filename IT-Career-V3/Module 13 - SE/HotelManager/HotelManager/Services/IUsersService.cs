using HotelManager.ViewModels.Users;
using System.Threading.Tasks;

namespace HotelManager.Services
{
    public interface IUsersService
    {
        Task CreateUserAsync(CreateUserViewModel model);
        Task DeleteUserAsync(string id);
        Task EditUserAsync(EditUserViewModel model);
        Task<IndexUsersViewModel> GetUsersAsync(IndexUsersViewModel model);
        Task<EditUserViewModel> GetUserToEdit(string id);
        Task<DetailsUserViewModel> GetUserDetailsAsync(string id);
    }
}