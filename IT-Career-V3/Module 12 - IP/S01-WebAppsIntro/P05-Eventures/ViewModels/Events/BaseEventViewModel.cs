using System;
using System.ComponentModel.DataAnnotations;

namespace P05_Eventures.ViewModels.Events
{
    public class BaseEventViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Place { get; set; }
        public int TotalTickets { get; set; }
        public double PricePerTicket { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
