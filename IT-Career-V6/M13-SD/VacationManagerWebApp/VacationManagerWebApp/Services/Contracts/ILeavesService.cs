using VacationManagerWebApp.ViewModels.Leaves;

namespace VacationManagerWebApp.Services.Contracts
{
    public interface ILeavesService
    {
        public Task<string> CreateSickLeaveAsync(CreateSickLeaveViewModel viewModel);
        public Task<string> CreateUnPaidLeaveAsync(CreateUnpaidLeaveViewModel viewModel);
        public Task<string> CreatePaidLeaveAsync(CreatePaidLeaveViewModel viewModel);
    }
}
