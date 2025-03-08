using System.ComponentModel.DataAnnotations;

namespace VacationManagerWebApp.ViewModels.Projects
{
    public class CreateProjectViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
