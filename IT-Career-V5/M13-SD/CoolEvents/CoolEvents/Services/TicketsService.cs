using CoolEvents.Data;
using CoolEvents.Data.Models;
using CoolEvents.Services.Contracts;
using CoolEvents.ViewModels.Tickets;
using CoolEvents.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CoolEvents.Services
{

    public class TicketsService : ITicketsService
    {
        private readonly ApplicationDbContext context;

        public TicketsService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<CreateTicketViewModel> GetCreateViewModelInfoAsync(string ticketId)
        {
            Event? @event = await context
                  .Events
                  .FindAsync(ticketId);

            return new CreateTicketViewModel
            {
                EventName = @event.Name,
                EventDate = @event.PremiereDate.ToShortDateString()
            };

        }

        public async Task<string> CreateTicketAsync(CreateTicketViewModel model)
        {
            Ticket ticket = new Ticket()
            {
                UserId = model.UserId,
                EventId = model.EventId
            };
            await context.Tickets.AddAsync(ticket);
            await context.SaveChangesAsync();
            return ticket.Id;
        }

        public async Task<IndexTicketsViewModel> GetTicketsAsync(IndexTicketsViewModel model)
        {
            if (model == null)
            {
                model = new IndexTicketsViewModel(0);
            }

            IQueryable<Ticket> dataTickets = context.Tickets;

            if (!string.IsNullOrWhiteSpace(model.LoggedUserId))
            {
                dataTickets = dataTickets.Where(x => x.UserId == model.LoggedUserId);
            }

            model.ElementsCount = await dataTickets.CountAsync();

            model.Tickets = await dataTickets
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexTicketViewModel()
                {
                    Id = x.Id,
                    EventId = x.EventId,
                    EventName = x.Event.Name,
                    EventDate = x.Event.PremiereDate.ToShortDateString(),
                    UserFullName = $"{x.User.FirstName} {x.User.LastName}",
                    UserId = x.UserId,
                })
                .ToListAsync();

            return model;
        }
    }
}
