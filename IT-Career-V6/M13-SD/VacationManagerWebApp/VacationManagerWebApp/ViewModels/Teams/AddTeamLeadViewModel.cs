using Microsoft.AspNetCore.Mvc.Rendering;

namespace VacationManagerWebApp.ViewModels.Teams
{
    public class AddTeamLeadViewModel
    {
        public string TeamId { get; set; }

        public string? TeamName { get; set; }

        public string TeamLeadId { get; set; }

        public SelectList? TeamLeads { get; set; }
    }
}
