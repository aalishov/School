using VacationManagerWebApp.Data.Models.Enums;

namespace VacationManagerWebApp.ViewModels.Leaves
{
    public class CreatePaidLeaveViewModel
    {
        public LeaveType Type { get; set; } = LeaveType.Paid;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool HalfDay { get; set; }

        public string UserId { get; set; }
    }
}
