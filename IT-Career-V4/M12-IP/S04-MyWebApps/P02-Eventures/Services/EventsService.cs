using Microsoft.EntityFrameworkCore;
using P02_Eventures.Data;
using P02_Eventures.Data.Models;
using P02_Eventures.ViewModels.Events;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace P02_Eventures.Services
{
    public class EventsService : IEventsService
    {
        private readonly ApplicationDbContext context;

        public EventsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IndexEventsViewModel> GetEventsAsync(int page = 1, int count = 10)
        {
            await SeedEvents();

            IndexEventsViewModel model = new IndexEventsViewModel();
            model.Events = await context.Events
                .Skip((page - 1) * count)
                .Take(count)
                .Select(x => new IndexEventViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Place = x.Place,
                    Start = x.Start.ToShortTimeString(),
                    End = x.End.ToShortTimeString(),
                    Price = x.PricePerTicket.ToString("c2"),
                    Tickets = $"{x.Orders.Sum(x => x.TicketsCount)} / {x.TotalTickets}"
                })
                .ToListAsync();
            model.ElementsCount = model.Events.Count;
            model.ItemsPerPage = count;
            model.PageNumber = page;

            return model;
        }

        private async Task<int> GetEventSoldTickets(string eventId)
        {
            var result = await this.context.Orders
                 .Where(x => x.EventId == eventId)
                 .ToListAsync();
            return result.Sum(x => x.TicketsCount);
        }

        private async Task SeedEvents()
        {
            if (!await context.Events.AnyAsync())
            {
                for (int i = 0; i < 50; i++)
                {
                    await context.Events.AddAsync(new Event
                    {
                        Name = $"Event {i}",
                        Place = $"Place {i}",
                        Start = DateTime.UtcNow,
                        End = DateTime.UtcNow.AddDays(1),
                        PricePerTicket = 10 + i * 2,
                        TotalTickets = 100,
                    });
                }
                await context.SaveChangesAsync();
            }
        }
    }
}
