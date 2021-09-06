namespace P01_HospitalDatabase.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Medicament
    {
        public Medicament()
        {
            this.PatientsMedicaments = new HashSet<PatientMedicament>();
        }

        [Key]
        public int MedicamentId { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        public virtual ICollection<PatientMedicament> PatientsMedicaments { get; set; }
    }
}
