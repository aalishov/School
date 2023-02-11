using P02_Eventures.Data;
using P02_Eventures.Data.Models;
using P02_Eventures.ViewModels.Orders;
using System.Threading.Tasks;

namespace P02_Eventures.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly ApplicationDbContext context;

        public OrdersService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task CreateOrderAsync(CreateOrderViewModel model)
        {
            

            Order order = new Order()
            {
                CustomerId = model.CustomerId,
                EventId = model.EventId,
                TicketsCount = model.TicketsCount,
            };

            await this.context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
        }
    }
}
