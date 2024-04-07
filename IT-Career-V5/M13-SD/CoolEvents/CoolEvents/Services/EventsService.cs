using CoolEvents.Data;
using CoolEvents.Data.Models;
using CoolEvents.Services.Contracts;
using CoolEvents.ViewModels.Events;
using CoolEvents.ViewModels.Tickets;
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

        public async Task<string> CreateEventAsync(CreateEventViewModel model)
        {
            Event @event = new Event()
            {
                Name = model.Name,
                Description = model.Description,
                Image = await ImageToStringAsync(model.ImageFile),
                PremiereDate = model.PremiereDate,
            };

            await context.Events.AddAsync(@event);
            await context.SaveChangesAsync();

            return @event.Id;
        }

        public async Task<IndexEventsViewModel> GetEventsAsync(IndexEventsViewModel model)
        {
            if (model == null)
            {
                model = new IndexEventsViewModel(0);
            }

            IQueryable<Event> data = context.Events;

            if (!string.IsNullOrWhiteSpace(model.FilterByName))
            {
                data = data.Where(x => x.Name.Contains(model.FilterByName));
            }

            model.ElementsCount = await data.CountAsync();

            model.Events = await data
                .Where(x => x.PremiereDate >= DateTime.UtcNow)
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexEventViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    PremiereDate = x.PremiereDate.ToLongDateString(),
                    Image = x.Image,
                    BookedTickets = x.Tickets.Count,
                })
                .ToListAsync();

            return model;
        }

        private async Task<string> ImageToStringAsync(IFormFile file)
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
