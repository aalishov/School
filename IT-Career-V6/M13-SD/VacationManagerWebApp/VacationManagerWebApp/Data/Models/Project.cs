using System.ComponentModel.DataAnnotations;

namespace VacationManagerWebApp.Data.Models
{
    public class Project
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

        public virtual ICollection<Team> Teams { get; set; } = new HashSet<Team>();
    }
}
