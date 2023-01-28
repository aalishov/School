using P01_Cars.ViewModels.Cars;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P01_Cars.Services
{
    public interface ICarsService
    {
        Task<List<IndexCarViewModel>> GetCarsBasicInfoAsync();
        Task<DetailsCarViewModel> GetCarDetailsAsync(int id);
        Task CreateCarAsync(CreateCarViewModel inputModel);
    }
}