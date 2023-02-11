using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace P02_Eventures.ViewModels.Events
{
    public class CreateEventViewModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [Range(0, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Range(0,double.MaxValue)]
        public decimal PricePerTicket { get; set; }
    }
}
