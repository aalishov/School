namespace VacationManagerWebApp.Services
{
    using Contracts;
    using VacationManagerWebApp.Data;
    using VacationManagerWebApp.Data.Models;
    using VacationManagerWebApp.ViewModels.Leaves;

    public class LeavesService : ILeavesService
    {
        private readonly ApplicationDbContext context;

        public LeavesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<string> CreateSickLeaveAsync(CreateSickLeaveViewModel viewModel)
        {
            Leave leave = new Leave()
            {
                Type = viewModel.Type,
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
    }
}
