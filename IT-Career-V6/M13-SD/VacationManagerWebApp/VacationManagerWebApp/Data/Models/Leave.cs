namespace VacationManagerWebApp.Data.Models
{
    using Enums;
    public class Leave
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public LeaveType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public bool HalfDay { get; set; }

        public bool Approved { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public  string? File { get; set; }
    }
}
