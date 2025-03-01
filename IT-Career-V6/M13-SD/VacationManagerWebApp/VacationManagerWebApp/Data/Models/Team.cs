using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace VacationManagerWebApp.Data.Models
{
    public class Team
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? TeamLeadId { get; set; }

        public virtual User? TeamLead { get; set; }


        public string? ProjectId { get; set; }

        public virtual Project? Project { get; set; }


        public virtual ICollection<User> Developers { get; set; } = new HashSet<User>();
    }
}
