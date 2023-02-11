using P02_Eventures.ViewModels.Orders;
using System.Threading.Tasks;

namespace P02_Eventures.Services
{
    public interface IOrdersService
    {
        Task CreateOrderAsync(CreateOrderViewModel model);
    }
}