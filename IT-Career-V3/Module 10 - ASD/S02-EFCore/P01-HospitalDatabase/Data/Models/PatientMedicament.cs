namespace P01_HospitalDatabase.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class PatientMedicament
    {
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }
              
        public virtual Patient Patient { get; set; }

        [ForeignKey(nameof(Medicament))]
        public int MedicamentId { get; set; }

        public virtual Medicament Medicament { get; set; }
    }
}
