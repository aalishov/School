using P05_Eventures.ViewModels.Events;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P05_Eventures.Services.Contracts
{
    public interface IEventsService
    {
        public Task CreateEventAsync(CreateEventViewModel model);
        public Task<IndexEventViewModel> GetEventAsync(string id);
        public Task<EditEventViewModel> GetEventForEdit(string id);
        public Task<IndexEventsViewModel> GetAllEventsAsync(int page);
        public Task<IndexUserEventsViewModel> GetAllEventsForUserAsync(int page);
        public Task EditEventAsync(EditEventViewModel model);
        public Task OrderAsync(string id, int count, string userId);
    }
}
