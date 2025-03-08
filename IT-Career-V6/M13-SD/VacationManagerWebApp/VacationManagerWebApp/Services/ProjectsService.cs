using VacationManagerWebApp.Data;
using VacationManagerWebApp.Data.Models;
using VacationManagerWebApp.Services.Contracts;
using VacationManagerWebApp.ViewModels.Projects;

namespace VacationManagerWebApp.Services
{
    public class ProjectsService:IProjectsService
    {
        private readonly ApplicationDbContext context;

        public ProjectsService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<string> CreateProjectAsync(CreateProjectViewModel viewModel)
        {
            Project project = new Project()
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
            };

            context.Projects.Add(project);
            await context.SaveChangesAsync();
            return project.Id;
        }
    }
}
