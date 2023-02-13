namespace P02_Eventures.Services
{
    using ViewModels.Events;
    using System.Threading.Tasks;
    public interface IEventsService
    {
        Task CreateEventAsync(CreateEventViewModel model);
        Task DeleteEventByIdAsync(string id);
        Task<EditEventViewModel> GetEventEditViewModelByIdAsync(string id);
        Task<IndexEventsViewModel> GetEventsAsync(string place, int page = 1, int count = 10);
        Task<DetailsEventViewModel> GetEventDetailsById(string id);
        Task<int> GetEventFreeTickets(string eventId);
        Task UpdateEventAsync(EditEventViewModel model);
    }
}