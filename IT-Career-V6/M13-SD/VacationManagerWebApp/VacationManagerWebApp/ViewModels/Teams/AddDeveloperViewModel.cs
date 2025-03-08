using Microsoft.AspNetCore.Mvc.Rendering;

namespace VacationManagerWebApp.ViewModels.Teams
{
    public class AddDeveloperViewModel
    {
        public string TeamId { get; set; }

        public string? TeamName { get; set; }

        public string DeveloperId { get; set; }

        public SelectList? Developers { get; set; }
    }
}
