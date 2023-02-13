using Microsoft.EntityFrameworkCore;
using P02_Eventures.Data;
using P02_Eventures.Data.Models;
using P02_Eventures.ViewModels.Orders;
using System.Linq;
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

        public async Task<UserOrdersViewModel> GetUserOrdersByIdAsync(string userId, int page = 1, int count = 10)
        {
            UserOrdersViewModel model = new UserOrdersViewModel();

            model.ItemsPerPage = count;
            model.PageNumber = page;
            model.ElementsCount = this.context.Orders.Count(x => x.CustomerId == userId);

            model.Orders = await this.context.Orders
                .Where(x => x.CustomerId == userId)
                .Skip((page - 1) * count)
                .Select(x => new UserOrderViewModel()
                {
                    UserId = userId,
                    EventId = x.EventId,
                    EventPlace = x.Event.Place,
                    EventName = x.Event.Name,
                    OrderId = x.Id,
                    TicketsCount=x.TicketsCount.ToString(),
                    OrderPrice = (x.Event.PricePerTicket * x.TicketsCount).ToString()

                })
                .ToListAsync();

            return model;
        }
    }
}
