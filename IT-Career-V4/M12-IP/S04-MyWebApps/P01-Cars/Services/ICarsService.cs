using P01_Cars.ViewModels.Cars;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P01_Cars.Services
{
    public interface ICarsService
    {
        Task CreateCarAsync(CreateCarViewModel inputModel);
        Task DeleteCarByIdAsync(int id);
        Task<List<IndexCarViewModel>> GetCarsBasicInfoAsync();
        Task<DetailsCarViewModel> GetCarDetailsAsync(int id);
        Task<EditCarViewModel> GetCarToEditAsync(int id);
        Task UpdateCarDetailsAsync(EditCarViewModel model);
    }
}