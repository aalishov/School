using VacationManagerWebApp.ViewModels.Leaves;

namespace VacationManagerWebApp.Services.Contracts
{
    public interface ILeavesService
    {
        public Task<string?> ApproveLeaveAsync(string leaveId);
        public Task<Stream> StringToStream(string file);
        public Task<IndexLeavesViewModel> GetLeavesAsync(IndexLeavesViewModel model);
        public Task<string> CreateSickLeaveAsync(CreateSickLeaveViewModel viewModel);
        public Task<string> CreateUnPaidLeaveAsync(CreateUnpaidLeaveViewModel viewModel);
        public Task<string> CreatePaidLeaveAsync(CreatePaidLeaveViewModel viewModel);
    }
}
