using P02_Eventures.ViewModels.Events;
using System.Threading.Tasks;

namespace P02_Eventures.Services
{
    public interface IEventsService
    {
        Task<IndexEventsViewModel> GetEventsAsync(int page = 1, int count = 10);
    }
}