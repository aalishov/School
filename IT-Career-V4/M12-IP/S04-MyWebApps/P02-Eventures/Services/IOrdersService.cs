using P02_Eventures.ViewModels.Orders;
using System.Threading.Tasks;

namespace P02_Eventures.Services
{
    public interface IOrdersService
    {
        Task CreateOrderAsync(CreateOrderViewModel model);
        Task<UserOrdersViewModel> GetUserOrdersByIdAsync(string userId, int page = 1, int count = 10);
    }
}