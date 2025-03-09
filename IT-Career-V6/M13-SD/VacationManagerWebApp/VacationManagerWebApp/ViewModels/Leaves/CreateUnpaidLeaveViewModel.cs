using VacationManagerWebApp.Data.Models.Enums;

namespace VacationManagerWebApp.ViewModels.Leaves
{
    public class CreateUnpaidLeaveViewModel
    {
        public LeaveType Type { get; set; } = LeaveType.Unpaid;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool HalfDay { get; set; }

        public string UserId { get; set; }
    }
}
