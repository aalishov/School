using System.ComponentModel.DataAnnotations;

namespace CoolEvents.ViewModels.Events
{
    public class CreateEventViewModel
    {
        [Required]
        [MinLength(1)]
        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        public DateTime Date { get; set; }

        public IFormFile? File { get; set; }

    }
}
