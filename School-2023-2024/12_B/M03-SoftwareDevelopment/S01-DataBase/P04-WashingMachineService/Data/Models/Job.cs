namespace WashingMachineService.Data.Models
{
    
    public class Job
    {
        public int JobId { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public string Status { get; set; } = "Pending";
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? MechanicId { get; set; }
        public virtual Mechanic Mechanic { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<PartNeeded> PartsNeeded { get; set; } = new List<PartNeeded>();

    }
}
