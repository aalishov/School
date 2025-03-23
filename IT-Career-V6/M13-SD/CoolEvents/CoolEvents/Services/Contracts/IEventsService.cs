using CoolEvents.ViewModels.Events;

namespace CoolEvents.Services.Contracts
{
    public interface IEventsService
    {

        public Task<string> BookEventAsync(string eventId, string userId);
        public Task<string> CreateEventAsync(CreateEventViewModel viewModel);

        public Task<IndexEventsViewModel> GetEventsAsync(IndexEventsViewModel model);

        
    }
}
