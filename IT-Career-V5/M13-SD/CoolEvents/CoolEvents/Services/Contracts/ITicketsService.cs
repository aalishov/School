using CoolEvents.ViewModels.Tickets;

namespace CoolEvents.Services.Contracts
{
    public interface ITicketsService
    {
        public Task<CreateTicketViewModel> GetCreateViewModelInfoAsync(string ticketId);
        public Task<string> CreateTicketAsync(CreateTicketViewModel model);

        public Task<IndexTicketsViewModel> GetTicketsAsync(IndexTicketsViewModel model);
    }
}
