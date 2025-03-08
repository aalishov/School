using Microsoft.AspNetCore.Mvc.Rendering;

namespace VacationManagerWebApp.ViewModels.Teams
{
    public class AddProjectViewModel
    {
        public string TeamId { get; set; }

        public string? TeamName { get; set; }

        public string ProjectId { get; set; }

        public SelectList? Projects { get; set; }
    }
}
