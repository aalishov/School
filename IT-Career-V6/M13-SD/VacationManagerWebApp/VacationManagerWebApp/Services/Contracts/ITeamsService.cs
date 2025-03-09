using VacationManagerWebApp.ViewModels.Teams;

namespace VacationManagerWebApp.Services.Contracts
{
    public interface ITeamsService
    {
        public Task<string> RemoveDeveloper(string userId);
        public Task<string> AddDeveloperAsync(AddDeveloperViewModel viewModel);
        public Task<AddDeveloperViewModel> GetTeamToAddDeveloperAsync(string teamId);
        public Task<string> AddProjectAsync(AddProjectViewModel viewModel);
        public Task<AddProjectViewModel> GetTeamToAddProject(string teamId);
        public Task<string> AddTeamLeadAsync(AddTeamLeadViewModel viewModel);
        public Task<AddTeamLeadViewModel> GetTeamToAddTeamLeadAsync(string teamId);
        public Task<DetailsTeamViewModel> GetTeamDetailsAsync(string teamId);
        public Task<IndexTeamsViewModel> GetTeamsAsync(IndexTeamsViewModel model);
        public Task<string> CreateTeamAsync(CreateTeamViewModel model);
    }
}
