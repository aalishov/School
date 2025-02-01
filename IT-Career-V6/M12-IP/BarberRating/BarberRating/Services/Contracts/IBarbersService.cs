using BarberRating.ViewModels.Barbers;

namespace BarberRating.Services.Contracts
{
    public interface IBarbersService
    {
        public Task<string> CreateBarberAsync(CreateBarberViewModel model);

        public Task<IndexBarbersViewModel> GetBarbersAsync(IndexBarbersViewModel model);

        public Task<string> UpdateBarberAsync(EditBarberViewModel model);

        public Task<EditBarberViewModel> GetBarberToEditAsync(string barberId);
    }
}
