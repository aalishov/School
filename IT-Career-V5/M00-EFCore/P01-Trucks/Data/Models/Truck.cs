using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trucks.Data.Models.Enums;

namespace Trucks.Data.Models
{
    public class Truck
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(8)]
        public string? RegistrationNumber { get; set; }

        [Required]
        [MaxLength(17)]
        public string VinNumber { get; set; }

        [Range(950, 1420)]
        public int? TankCapacity { get; set; }

        [Range(5000, 29000)]
        public int? CargoCapacity { get; set; }

        [Required]
        public CategoryType CategoryType { get; set; }

        [Required]
        public MakeType MakeType { get; set; }

        [Required]
        public int DespatcherId { get; set; }
        public virtual Despatcher Despatcher { get; set; }

        public virtual List<ClientTruck> ClientsTrucks { get; set; } = new List<ClientTruck>();
    }
}
