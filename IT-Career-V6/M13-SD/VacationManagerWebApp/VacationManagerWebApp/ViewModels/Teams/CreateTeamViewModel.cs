using System.ComponentModel.DataAnnotations;

namespace VacationManagerWebApp.ViewModels.Teams
{
    public class CreateTeamViewModel
    {
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string Name { get; set; }
    }
}
