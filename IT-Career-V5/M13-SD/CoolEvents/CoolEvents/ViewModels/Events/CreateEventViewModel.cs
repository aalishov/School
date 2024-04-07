using System.ComponentModel.DataAnnotations;

namespace CoolEvents.ViewModels.Events
{
    public class CreateEventViewModel
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public IFormFile? ImageFile { get; set; }

        [Display(Name="Premiere date")]
        public DateTime PremiereDate { get; set; }
    }
}
