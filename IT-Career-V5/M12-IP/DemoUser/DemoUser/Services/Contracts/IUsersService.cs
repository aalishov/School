using DemoUser.ViewModels.Users;

namespace DemoUser.Services.Contracts
{
    public interface IUsersService
    {
        public Task<ICollection<IndexUserViewModel>> GetAllUsersAsync();

        public Task<EditUserViewModel> GetUserToEdit(string id);

        public Task<string> CreateUserAsync(CreateUserViewModel model);

        public Task<string> EditUserAsync(EditUserViewModel model);

        public Task<bool> DeleteUserAsync(string id);
    }
}
