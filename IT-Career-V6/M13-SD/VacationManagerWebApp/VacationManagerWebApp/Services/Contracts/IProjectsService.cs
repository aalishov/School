using VacationManagerWebApp.ViewModels.Projects;

namespace VacationManagerWebApp.Services.Contracts
{
    public interface IProjectsService
    {
        public Task<string> CreateProjectAsync(CreateProjectViewModel viewModel);
    }
}
