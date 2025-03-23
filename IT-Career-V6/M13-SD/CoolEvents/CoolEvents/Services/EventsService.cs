using CoolEvents.Data;
using CoolEvents.Data.Models;
using CoolEvents.Services.Contracts;
using CoolEvents.ViewModels.Events;
using Microsoft.EntityFrameworkCore;

namespace CoolEvents.Services
{
    public class EventsService : IEventsService
    {
        private readonly ApplicationDbContext context;

        public EventsService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<string> BookEventAsync(string eventId, string userId)
        {
            User user = await context.Users.FindAsync(userId);
            Event @event = await context.Events.FindAsync(eventId);

            Ticket ticket = new Ticket()
            {
                User = user,
                Event = @event
            };
            await context.Tickets.AddAsync(ticket);
            await context.SaveChangesAsync();
            return ticket.Id;
        }
        public async Task<string> CreateEventAsync(CreateEventViewModel viewModel)
        {
            if (viewModel == null) { return null; }

            Event newEvent = new Event()
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                Date = viewModel.Date,
                Image = await FileToStringAsync(viewModel.File),
            };

            context.Events.Add(newEvent);
            await context.SaveChangesAsync();

            return newEvent.Id;
        }

        public async Task<IndexEventsViewModel> GetEventsAsync(IndexEventsViewModel model)
        {
            if (model == null)
            {
                model = new IndexEventsViewModel(10);
            }
            IQueryable<Event> data = context.Events;

            if (!string.IsNullOrWhiteSpace(model.FilterByName))
            {
                data = context.Events.Where(x => x.Name.Contains(model.FilterByName));
            }

            model.ElementsCount = await data.CountAsync();

            model.Events = await data
              .Skip((model.Page - 1) * model.ItemsPerPage)
              .Take(model.ItemsPerPage)
              .Select(x => new BaseEventViewModel()
              {
                  Id = x.Id,
                  Name = x.Name,
                  Date = x.Date.ToString("dd-MM-yyyy"),
                  Image = x.Image
              })
              .ToListAsync();

            return model;
        }

        private async Task<string> FileToStringAsync(IFormFile file)
        {
            List<string> imageExtensions = new List<string>() { ".JPG", ".BMP", ".PNG" };


            if (file != null) // check if the user uploded something
            {
                var extension = Path.GetExtension(file.FileName); //get file extension
                if (imageExtensions.Contains(extension.ToUpperInvariant()))
                {
                    using var dataStream = new MemoryStream();
                    await file.CopyToAsync(dataStream);
                    byte[] imageBytes = dataStream.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
            return null;
        }
    }
}
