using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VacationManagerWebApp.Data;
using VacationManagerWebApp.Data.Models;
using VacationManagerWebApp.Services.Contracts;
using VacationManagerWebApp.ViewModels.Teams;
using VacationManagerWebApp.ViewModels.Users;

namespace VacationManagerWebApp.Services
{
    public class TeamsService : ITeamsService
    {
        private readonly ApplicationDbContext context;

        public TeamsService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<string> AddDeveloperAsync(AddDeveloperViewModel viewModel)
        {
            Team team = context.Teams.Find(viewModel.TeamId);
            if (team == null) { return null; }


            team.Developers.Add(await context.Users.FindAsync(viewModel.DeveloperId));
            context.Teams.Update(team);
            await context.SaveChangesAsync();
            return team.Id;
        }

        public async Task<AddDeveloperViewModel> GetTeamToAddDeveloperAsync(string teamId)
        {
            Team team = context.Teams.Find(teamId);
            if (team == null) { return null; }

            string developerRoleId = context.Roles.FirstOrDefault(x => x.Name == GlobalConstants.DeveloperRole).Id;

            return new AddDeveloperViewModel()
            {
                TeamId = teamId,
                TeamName = team.Name,
                Developers = new SelectList(context.Users
                .Where(x => x.Roles.Any(x => x.RoleId == developerRoleId) && !context.Teams.Any(t=>t.Developers.Any(d=>d.Id==x.Id)))
                .Select(u => new
                {
                    u.Id,
                    FullName = $"{u.FirstName} {u.LastName}"
                }), "Id", "FullName")
            };
        }



        public async Task<string> AddProjectAsync(AddProjectViewModel viewModel)
        {
            Team team = context.Teams.Find(viewModel.TeamId);
            if (team == null) { return null; }

            if (team.Project != null)
            {
                team.Project = null;
            }

            team.Project = context.Projects.Find(viewModel.ProjectId);
            context.Teams.Update(team);
            await context.SaveChangesAsync();
            return team.Id;
        }

        public async Task<AddProjectViewModel> GetTeamToAddProject(string teamId)
        {
            Team team = context.Teams.Find(teamId);
            if (team == null) { return null; }


            return new AddProjectViewModel()
            {
                TeamId = teamId,
                TeamName = team.Name,
                Projects = new SelectList(context.Projects, "Id", "Name")
            };
        }

        public async Task<string> AddTeamLeadAsync(AddTeamLeadViewModel viewModel)
        {
            Team team = context.Teams.Find(viewModel.TeamId);
            if (team == null) { return null; }

            if (team.TeamLead != null)
            {
                team.TeamLead = null;
            }

            team.TeamLead = context.Users.Find(viewModel.TeamLeadId);
            context.Teams.Update(team);
            await context.SaveChangesAsync();
            return team.Id;
        }

        public async Task<AddTeamLeadViewModel> GetTeamToAddTeamLeadAsync(string teamId)
        {
            Team team = context.Teams.Find(teamId);
            if (team == null) { return null; }

            string teamLeadRoleId = context.Roles.FirstOrDefault(x => x.Name == GlobalConstants.TeamLeadRole).Id;

            return new AddTeamLeadViewModel()
            {
                TeamId = teamId,
                TeamName = team.Name,
                TeamLeads = new SelectList(context.Users.Where(x => x.Roles
                .Any(x => x.RoleId == teamLeadRoleId))
                .Select(u => new
                {
                    u.Id,
                    FullName = $"{u.FirstName} {u.LastName}"
                }), "Id", "FullName")
            };
        }

        public async Task<DetailsTeamViewModel> GetTeamDetailsAsync(string teamId)
        {
            Team team = context.Teams.Find(teamId);

            if (team == null) { return null; }

            return new DetailsTeamViewModel()
            {
                Id = team.Id,
                Name = team.Name,
                TeamLead = team.TeamLead != null ? $"{team.TeamLead.FirstName} {team.TeamLead.LastName}" : "n/a",
                Project = team.Project != null ? team.Project.Name : "n/a",
                Developers=team.Developers
            };
        }

        public async Task<IndexTeamsViewModel> GetTeamsAsync(IndexTeamsViewModel model)
        {
            if (model == null)
            {
                model = new IndexTeamsViewModel(0);
            }

            IQueryable<Team> dataUsers = context.Teams;

            if (!string.IsNullOrWhiteSpace(model.FilterByName))
            {
                dataUsers = dataUsers.Where(x => x.Name.Contains(model.FilterByName));
            }

            model.ElementsCount = await dataUsers.CountAsync();

            if (model.IsAsc)
            {
                model.IsAsc = false;
                dataUsers = dataUsers.OrderByDescending(x => x.Name);

            }
            else
            {
                model.IsAsc = true;
                dataUsers = dataUsers.OrderBy(x => x.Name);
            }

            model.Teams = await dataUsers
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexTeamViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    TeamLeadName = x.TeamLead != null ? $"{x.TeamLead.FirstName} {x.TeamLead.LastName}" : "n/a",
                    ProjectName = x.Project != null ? x.Project.Name : "n/a",
                    DevelopersCount = x.Developers.Count.ToString(),
                })
                .ToListAsync();

            return model;
        }

        public async Task<string> CreateTeamAsync(CreateTeamViewModel model)
        {
            Team team = new Team()
            {
                Name = model.Name,
            };

            context.Add(team);
            await context.SaveChangesAsync();
            return team.Id;
        }

    }
}
