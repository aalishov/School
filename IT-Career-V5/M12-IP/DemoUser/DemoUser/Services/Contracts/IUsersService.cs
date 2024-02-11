using DemoUser.ViewModels.Users;

namespace DemoUser.Services.Contracts
{
    public interface IUsersService
    {
        public Task<IndexUsersViewModel> GetUsersAsync(int page, string order = "Asc", int itemsPerPage=5);

        public Task<EditUserViewModel> GetUserToEdit(string id);

        public Task<string> CreateUserAsync(CreateUserViewModel model);

        public Task<string> EditUserAsync(EditUserViewModel model);

        public Task<bool> DeleteUserAsync(string id);
    }
}
