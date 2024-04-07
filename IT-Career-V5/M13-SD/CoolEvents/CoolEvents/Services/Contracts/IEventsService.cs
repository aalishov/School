using CoolEvents.ViewModels.Events;

namespace CoolEvents.Services.Contracts
{
    public interface IEventsService
    {
        public Task<string> CreateEventAsync(CreateEventViewModel model);

        public Task<IndexEventsViewModel> GetEventsAsync(IndexEventsViewModel model);
    }
}
