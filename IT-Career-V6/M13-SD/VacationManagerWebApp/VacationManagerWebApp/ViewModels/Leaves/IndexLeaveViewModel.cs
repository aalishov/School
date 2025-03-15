using VacationManagerWebApp.Data.Models.Enums;

namespace VacationManagerWebApp.ViewModels.Leaves
{
    public class IndexLeaveViewModel
    {
        public string Id { get; set; }
        public LeaveType Type { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string CreateDate { get; set; }

        public bool HalfDay { get; set; }

        public bool Approved { get; set; }

        public string UserFullName { get; set; }

        public string FileBase64 { get; set; }
    }
}
