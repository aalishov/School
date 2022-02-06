using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using P05_Eventures.Data;
using P05_Eventures.Data.Models;
using P05_Eventures.Services.Contracts;
using P05_Eventures.ViewModels.Events;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P05_Eventures.Services
{
    public class EventsService : IEventsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public EventsService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task CreateEventAsync(CreateEventViewModel model)
        {
            Event newEvent = mapper.Map<CreateEventViewModel, Event>(model);

            await context.Events.AddAsync(newEvent);
            await context.SaveChangesAsync();
        }
        public async Task<EditEventViewModel> GetEventForEdit(string id)
        {
            return await this.context.Events
                .ProjectTo<EditEventViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task EditEventAsync(EditEventViewModel model)
        {
            context.Update(mapper.Map<Event>(model));
            await context.SaveChangesAsync();
        }
        public async Task<IndexEventsViewModel> GetAllEventsAsync(int page)
        {
            IndexEventsViewModel events = new IndexEventsViewModel();
            events.PageNumber = page;
            events.Events = await context.Events.ProjectTo<IndexEventViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * events.ItemsPerPage)
                .Take(events.ItemsPerPage)
                .ToListAsync();
            events.ElementsCount = context.Events.Count();
            return events;
        }
        public async Task<IndexUserEventsViewModel> GetAllEventsForUserAsync(int page)
        {
            IndexUserEventsViewModel events = new IndexUserEventsViewModel();
            events.PageNumber = page;
            events.Events = await context.Events.ProjectTo<IndexUserEventViewModel>(this.mapper.ConfigurationProvider)
                .Skip((page - 1) * events.ItemsPerPage)
                .Take(events.ItemsPerPage)
                .ToListAsync();
            events.ElementsCount = context.Events.Count();
            return events;
        }
        public async Task<IndexEventViewModel> GetEventAsync(string id)
        {
            return await context.Events
                .ProjectTo<IndexEventViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task OrderAsync(string id, int count, string userId)
        {
            await context.Orders.AddAsync(new Order()
            {
                CustomerId = userId,
                EventId = id,
                TicketsCount = count
            }
            );
            await context.SaveChangesAsync();
        }
    }
}
