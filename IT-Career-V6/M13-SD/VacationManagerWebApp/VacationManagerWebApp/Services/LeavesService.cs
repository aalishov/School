namespace VacationManagerWebApp.Services
{
    using Contracts;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using VacationManagerWebApp.Data;
    using VacationManagerWebApp.Data.Models;
    using VacationManagerWebApp.ViewModels.Leaves;
    using VacationManagerWebApp.ViewModels.Teams;

    public class LeavesService : ILeavesService
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;

        public LeavesService(ApplicationDbContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<string?> ApproveLeaveAsync(string leaveId)
        {
            Leave? leave = await context.Leaves.FindAsync(leaveId);

            if (leave == null)
            {
                return null;
            }

            leave.Approved = true;
            context.Update(leave);
            await context.SaveChangesAsync();
            return leave.Id;
        }

        public async Task<IndexLeavesViewModel> GetLeavesAsync(IndexLeavesViewModel model)
        {
            if (model == null)
            {
                model = new IndexLeavesViewModel(0);
            }

            IQueryable<Leave> data = context.Leaves;
            User user = await context.Users.FindAsync(model.LoggedUserId);

            if (await userManager.IsInRoleAsync(user, GlobalConstants.DeveloperRole))
            {
                data = data.Where(x => x.UserId == model.LoggedUserId);
            }
            else if (await userManager.IsInRoleAsync(user, GlobalConstants.TeamLeadRole))
            {

                var developerIds = user.Team.Developers.Select(d => d.Id).ToList();
                data = data.Where(x => developerIds.Contains(x.UserId));
            }


            if (model.HideApproved)
            {
                data = data.Where(x => x.Approved==false);
            }

            if (!string.IsNullOrWhiteSpace(model.FilterByName))
            {
                data = data.Where(x => x.User.FirstName.Contains(model.FilterByName) || x.User.LastName.Contains(model.FilterByName));
            }

            model.ElementsCount = await data.CountAsync();

            if (model.IsAsc)
            {
                model.IsAsc = false;
                data = data.OrderByDescending(x => x.User.FirstName);

            }
            else
            {
                model.IsAsc = true;
                data = data.OrderBy(x => x.User.FirstName);
            }

            model.Leaves = await data
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new IndexLeaveViewModel()
                {
                    Id = x.Id,
                    StartDate = x.StartDate.ToString("dd-MM-yyyy"),
                    EndDate = x.EndDate.ToString("dd-MM-yyyy"),
                    CreateDate = x.CreateDate.ToString("dd-MM-yyyy"),
                    HalfDay = x.HalfDay,
                    Approved = x.Approved,
                    UserFullName = x.User != null ? $"{x.User.FirstName} {x.User.LastName}" : "n/a",
                    FileBase64 = x.File,
                })
                .ToListAsync();

            return model;
        }


        public async Task<string> CreateSickLeaveAsync(CreateSickLeaveViewModel viewModel)
        {
            Leave leave = new Leave()
            {
                Type = viewModel.Type,
                Approved = true,
                StartDate = viewModel.StartDate,
                EndDate = viewModel.EndDate,
                UserId = viewModel.UserId,
                File = await FileToStringAsync(viewModel.File)
            };

            context.Leaves.Add(leave);
            await context.SaveChangesAsync();
            return leave.Id;
        }

        public async Task<string> CreateUnPaidLeaveAsync(CreateUnpaidLeaveViewModel viewModel)
        {
            Leave leave = new Leave()
            {
                Type = viewModel.Type,
                StartDate = viewModel.StartDate,
                EndDate = viewModel.EndDate,
                UserId = viewModel.UserId,
                HalfDay = viewModel.HalfDay,
            };

            context.Leaves.Add(leave);
            await context.SaveChangesAsync();
            return leave.Id;
        }

        public async Task<string> CreatePaidLeaveAsync(CreatePaidLeaveViewModel viewModel)
        {
            Leave leave = new Leave()
            {
                Type = viewModel.Type,
                StartDate = viewModel.StartDate,
                EndDate = viewModel.EndDate,
                UserId = viewModel.UserId,
                HalfDay = viewModel.HalfDay,
            };

            context.Leaves.Add(leave);
            await context.SaveChangesAsync();
            return leave.Id;
        }

        private async Task<string> FileToStringAsync(IFormFile file)
        {
            List<string> imageExtensions = new List<string>() { ".JPG", ".BMP", ".PNG", ".PDF" };


            if (file != null) // check if the user uploded something
            {
                var extension = Path.GetExtension(file.FileName); //get file extension
                if (imageExtensions.Contains(extension.ToUpperInvariant()))
                {
                    using var dataStream = new MemoryStream();
                    await file.CopyToAsync(dataStream);
                    byte[] imageBytes = dataStream.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
            return null;
        }
        public async Task<Stream> StringToStream(string file)
        {
            byte[] pdfBytes = Convert.FromBase64String(file);
            return new MemoryStream(pdfBytes);
        }
    }
}
