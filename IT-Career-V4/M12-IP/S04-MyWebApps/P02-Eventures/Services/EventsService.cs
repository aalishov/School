namespace P02_Eventures.Services
{
    using Microsoft.EntityFrameworkCore;
    using P02_Eventures.Data;
    using P02_Eventures.Data.Models;
    using P02_Eventures.ViewModels.Events;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    public class EventsService : IEventsService
    {
        private readonly ApplicationDbContext context;

        public EventsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateEventAsync(CreateEventViewModel model)
        {
            if (model.Start > model.End)
            {
                throw new InvalidOperationException($"Invalid start/end date");
            }

            Event @event = new Event()
            {
                Name = model.Name,
                Place = model.Place,
                Start = model.Start,
                End = model.End,
                TotalTickets = model.TotalTickets,
                PricePerTicket = model.PricePerTicket,
            };
            await context.AddAsync(@event);
            await context.SaveChangesAsync();
        }
        public async Task DeleteEventByIdAsync(string id)
        {
            Event e = await this.context.Events.FindAsync(id);
            if (e == null) { throw new InvalidOperationException("Event not found!"); }
            this.context.Events.Remove(e);
            await this.context.SaveChangesAsync();
        }

        public async Task<EditEventViewModel> GetEventEditViewModelByIdAsync(string id)
        {
            Event e = await this.context.Events.FindAsync(id);
            if (e == null) { return null; }

            return new EditEventViewModel()
            {
                Id = e.Id,
                Name = e.Name,
                Place = e.Place,
                Start = e.Start,
                End = e.End,
                TotalTickets = e.TotalTickets,
                PricePerTicket = e.PricePerTicket,
            };
        }

        public async Task<int> GetEventFreeTickets(string eventId)
        {
            Event e =await this.context.Events.FindAsync(eventId);
            int result =e.TotalTickets-e.Orders.Sum(x=>x.TicketsCount);
            return result;
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
                    Start = x.Start.ToString("dd-MM-yyyy, HH:mm"),
                    End = x.End.ToString("dd-MM-yyyy, HH:mm"),
                    Price = x.PricePerTicket.ToString("c2"),
                    Tickets = $"{x.Orders.Sum(x => x.TicketsCount)} / {x.TotalTickets}"
                })
                .ToListAsync();
            model.ElementsCount = await context.Events.CountAsync();
            model.ItemsPerPage = count;
            model.PageNumber = page;

            return model;
        }

        public async Task<DetailsEventViewModel> GetEventDetailsById(string id)
        {
            Event e = await this.context.Events.FindAsync(id);

            if (e == null) { return null; }

            TimeSpan duration = e.End - e.Start;

            return new DetailsEventViewModel()
            {
                Id = e.Id,
                Name = e.Name,
                Place = e.Place,
                Start = e.Start.ToString("dd-MM-yyyy, HH:mm"),
                End = e.End.ToString("dd-MM-yyyy, HH:mm"),
                Duration = $"Days: {duration.Days}, Hours: {duration.Hours}, Minutes: {duration.Minutes}",
                Price = e.PricePerTicket.ToString("c2"),
                Tickets = $"{e.Orders.Sum(x => x.TicketsCount)} / {e.TotalTickets}"
            };
        }
        public async Task UpdateEventAsync(EditEventViewModel model)
        {
            Event e = await this.context.Events.FindAsync(model.Id);
            if (e == null)
            {
                throw new InvalidOperationException("Event not found!");
            }
            if (model.Start > model.End)
            {
                throw new InvalidOperationException("Invalid start/end date");
            }
            e.Name = model.Name;
            e.Place = model.Place;
            e.Start = model.Start;
            e.End = model.End;
            e.TotalTickets = model.TotalTickets;
            e.PricePerTicket = model.PricePerTicket;
            this.context.Update(e);
            await context.SaveChangesAsync();
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
